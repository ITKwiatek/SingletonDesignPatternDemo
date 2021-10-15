﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class TableServers
    {
        private static readonly TableServers _instance = new TableServers();
        private List<string> servers = new List<string>();
        private int nextServer = 0;

        public string GetNextServer()
        {
            string output = servers[nextServer];

            nextServer += 1;

            if(nextServer >= servers.Count)
            {
                nextServer = 0;
            }

            return output;
        }

        public static TableServers GetTableServers()
        {
            return _instance;
        }

        private TableServers()
        {
            servers.Add("Tim");
            servers.Add("Sue");
            servers.Add("Mary");
            servers.Add("Bob");
        }
    }
}
