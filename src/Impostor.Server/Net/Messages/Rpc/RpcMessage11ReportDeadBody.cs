﻿using Hazel;

namespace Impostor.Server.Net.Messages.Rpc
{
    internal static class RpcMessage11ReportDeadBody
    {

        public static void Deserialize(MessageReader reader, out byte playerId)
        {
            playerId = reader.ReadByte();
        }
    }
}