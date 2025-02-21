﻿using AAEmu.Game.Core.Managers;
using AAEmu.Game.Models.Game.Units.Movements;
using AAEmu.Game.Core.Packets.G2C;
using AAEmu.Game.Models.Game;
using AAEmu.Game.Models.Game.Char;
using AAEmu.Commons.Utils;
using NLog;
using AAEmu.Game.Utils.Scripts;

namespace AAEmu.Game.Scripts.Commands;

public class Nrot : ICommand
{
    protected static Logger Logger = LogManager.GetCurrentClassLogger();
    public void OnLoad()
    {
        CommandManager.Instance.Register("nrot", this);
    }

    public string GetCommandLineHelp()
    {
        return "(target) <x> <y> <z>";
    }

    public string GetCommandHelpText()
    {
        return "change target unit rotation";
    }

    public void Execute(Character character, string[] args, IMessageOutput messageOutput)
    {
        if (args.Length < 3)
        {
            character.SendMessage("[nrot] /nrot <x> <y> <z>");
            return;
        }

        if (character.CurrentTarget != null)
        {
            float value = 0;
            var rpyDegrees = character.CurrentTarget.Transform.Local.ToRollPitchYawDegrees();
            float x = character.CurrentTarget.Transform.Local.Position.X;
            float y = character.CurrentTarget.Transform.Local.Position.Y;
            float z = character.CurrentTarget.Transform.Local.Position.Z;

            if (float.TryParse(args[0], out value) && args[0] != "x")
            {
                x = value;
            }

            if (float.TryParse(args[1], out value) && args[1] != "y")
            {
                y = value;
            }

            if (float.TryParse(args[2], out value) && args[0] != "z")
            {
                z = value;
            }

            var Seq = (uint)Rand.Next(0, 10000);
            var moveType = (UnitMoveType)MoveType.GetType(MoveTypeEnum.Unit);

            moveType.X = character.CurrentTarget.Transform.Local.Position.X;
            moveType.Y = character.CurrentTarget.Transform.Local.Position.Y;
            moveType.Z = character.CurrentTarget.Transform.Local.Position.Z;

            character.CurrentTarget.Transform.Local.SetRotationDegree(x, y, z);

            var characterRot = character.CurrentTarget.Transform.Local.ToRollPitchYawSBytes();
            moveType.RotationX = characterRot.Item1;
            moveType.RotationY = characterRot.Item2;
            moveType.RotationZ = characterRot.Item3;

            moveType.Flags = 5;
            moveType.DeltaMovement = new sbyte[3];
            moveType.DeltaMovement[0] = 0;
            moveType.DeltaMovement[1] = 0;
            moveType.DeltaMovement[2] = 0;
            moveType.Stance = 1; //combat=0, idle=1
            moveType.Alertness = 0; //idle=0, combat=2
            moveType.Time = Seq;

            character.SendMessage($"[nrot] New position {character.CurrentTarget.Transform.Local}");
            character.BroadcastPacket(new SCOneUnitMovementPacket(character.CurrentTarget.ObjId, moveType), true);
        }
        else
            character.SendMessage("[nrot] You need to target something first");
    }
}
