﻿
using System.ComponentModel.DataAnnotations;
using BasicWebServer.Server.Common;

namespace BasicWebServer.Server.HTTP
{
    public class Session
    {
        public const string SessionCookieName = "MyWebServerSID";
        public const string SessionCurrentDataKey = "CurrentDate";

        private Dictionary<string, string> data;

        public Session(string id)
        {
            Guard.AgainstNull(id, nameof(id));

            this.Id = id;
            this.data = new Dictionary<string, string>();
        }

        public string Id { get; init; }

        public string this[string key]
        {
            get => this.data[key];
            set => this.data[key] = value;
        }

        public bool ContainsKey(string key) => this.data.ContainsKey(key);
    }
}