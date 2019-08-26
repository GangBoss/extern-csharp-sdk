﻿using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using ExternDotnetSDK.Clients.Common;
using ExternDotnetSDK.Clients.Common.Logging;
using ExternDotnetSDK.Clients.Common.RequestSenders;
using ExternDotnetSDK.Models.Accounts;
using ExternDotnetSDK.Models.Certificates;
using ExternDotnetSDK.Models.Warrants;

namespace ExternDotnetSDK.Clients.Accounts
{
    public class AccountClient : IAccountClient
    {
        private readonly InnerCommonClient client;

        public AccountClient(ILogger logger, IRequestSender requestSender) =>
            client = new InnerCommonClient(logger, requestSender);

        public async Task<AccountList> GetAccountsAsync(int skip = 0, int take = 100) =>
            await client.SendRequestAsync<AccountList>(
                HttpMethod.Get,
                "/v1",
                new Dictionary<string, object>
                {
                    ["skip"] = skip,
                    ["take"] = take
                });

        public async Task<Account> GetAccountAsync(Guid accountId) =>
            await client.SendRequestAsync<Account>(HttpMethod.Get, $"/v1/{accountId}");

        public async Task DeleteAccountAsync(Guid accountId) =>
            await client.SendRequestAsync(HttpMethod.Delete, $"/v1/{accountId}");

        public async Task<Account> CreateAccountAsync(string inn, string kpp, string organizationName) =>
            await client.SendRequestAsync<Account>(
                HttpMethod.Post,
                "/v1",
                contentDto: new CreateAccountRequestDto
                {
                    Inn = inn,
                    Kpp = kpp,
                    OrganizationName = organizationName
                });

        public async Task<CertificateList> GetAccountCertificatesAsync(
            Guid accountId,
            int skip = 0,
            int take = 100,
            bool forAllUsers = false) =>
            await client.SendRequestAsync<CertificateList>(
                HttpMethod.Get,
                $"/v1/{accountId}/certificates",
                new Dictionary<string, object>
                {
                    ["skip"] = skip,
                    ["take"] = take,
                    ["forAllUsers"] = forAllUsers
                });

        public async Task<WarrantList> GetAccountWarrantsAsync(
            Guid accountId,
            int skip = 0,
            int take = int.MaxValue,
            bool forAllUsers = false) =>
            await client.SendRequestAsync<WarrantList>(
                HttpMethod.Get,
                $"/v1/{accountId}/warrants",
                new Dictionary<string, object>
                {
                    ["skip"] = skip,
                    ["take"] = take,
                    ["forAllUsers"] = forAllUsers
                });
    }
}