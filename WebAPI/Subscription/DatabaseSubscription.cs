﻿using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TableDependency.SqlClient;
using WebAPI.Hubs;

namespace WebAPI.Subscription
{
    public interface IDatabaseSubscription
    {
        void Configure(string tableName);
    }

    public class DatabaseSubscription<T> : IDatabaseSubscription
        where T : class, new()
    {
        IConfiguration _configuration;
        IHubContext<CarHub> _hubContext;
        public DatabaseSubscription(IConfiguration configuration, IHubContext<CarHub> hubContext)
        {
            _configuration = configuration;
            _hubContext = hubContext;
        }

        SqlTableDependency<T> _tableDependency;
        public void Configure(string tableName)
        {
            _tableDependency = new SqlTableDependency<T>(_configuration.GetConnectionString("SQL"), tableName);

            _tableDependency.OnChanged += async (o, e) =>
            {
                await _hubContext.Clients.All.SendAsync("receiveMessage", e.Entity);
            };
            _tableDependency.OnError += (o, e) =>
            {

            };

            _tableDependency.Start();
        }
        ~DatabaseSubscription()
        {
            _tableDependency.Stop();
        }
    }
}
