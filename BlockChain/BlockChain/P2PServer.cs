﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using WebSocketSharp;
using WebSocketSharp.Server;

namespace BlockChain
{
    public class P2PServer: WebSocketBehavior
    {
        bool chainSynched = false;
        WebSocketServer wss = null;

        public void Start()
        {
            wss = new WebSocketServer($"ws://127.0.0.1:{Program.Port}");
            wss.AddWebSocketService<P2PServer>("/Blockchain");
            wss.Start();
            Console.WriteLine($"Started server at ws://127.0.0.1:{Program.Port}");
        }

        protected override void OnMessage(MessageEventArgs e)
        {
            if (e.Data == "Hi Server")
            {
                Console.WriteLine(e.Data);
                Send($"Hi Client");
            }
            else
            {
                BlockChain newChain = JsonConvert.DeserializeObject<BlockChain>(e.Data);

                if (newChain.IsValid() && newChain.Chain.Count > Program.TopCoin.Chain.Count)
                {
                    List<Transaction> newTransactions = new List<Transaction>();
                    newTransactions.AddRange(newChain.PendingTransactions);
                    newTransactions.AddRange(Program.TopCoin.PendingTransactions);

                    newChain.PendingTransactions = newTransactions;
                    Program.TopCoin = newChain;
                }

                if (!chainSynched)
                {
                    Send(JsonConvert.SerializeObject(Program.TopCoin));
                    chainSynched = true;
                }
            }
        }
    }
}
