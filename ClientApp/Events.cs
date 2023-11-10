﻿using System;
using System.Net.Sockets;
using Networking.Events;
using Networking.Models;

namespace ClientApp
{
    public class Events : IEventHandler
    {
        public string HandleAnalyserResult(Networking.Models.Message data)
        {
            throw new NotImplementedException();
        }

        public string HandleChatMessage(Networking.Models.Message data)
        {
            Console.WriteLine("[HandleChatMessage, cl] Recieved ChatMessage" + data.Data + " in call back function");
            return "";
        }

        public string HandleClientJoined(Networking.Models.Message data)
        {
            Console.WriteLine("[HandleClientJoined, cl] new client joinded: " + data.Data);
            return "";
        }

        public string HandleClientLeft(Networking.Models.Message data)
        {
            throw new NotImplementedException();
        }

        public string HandleConnectionRequest(Networking.Models.Message data)
        {
            throw new NotImplementedException();
        }

        public string HandleFile(Networking.Models.Message data)
        {
            throw new NotImplementedException();
        }

        string IEventHandler.HandleClientDeregister(Message message, Dictionary<string, NetworkStream> clientIDToStream, Dictionary<string, string> senderIDToClientID)
        {
            throw new NotImplementedException();
        }

        string IEventHandler.HandleClientRegister(Message message, Dictionary<string, NetworkStream> clientIDToStream, Dictionary<string, string> senderIDToClientID)
        {
            throw new NotImplementedException();
        }
    }
}

