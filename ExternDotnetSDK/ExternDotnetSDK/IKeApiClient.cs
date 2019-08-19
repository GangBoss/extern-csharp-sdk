﻿using ExternDotnetSDK.Clients.Account;
using ExternDotnetSDK.Clients.Docflows;
using ExternDotnetSDK.Clients.Drafts;
using ExternDotnetSDK.Clients.DraftsBuilders;
using ExternDotnetSDK.Clients.Events;
using ExternDotnetSDK.Clients.InventoryDocflows;
using ExternDotnetSDK.Clients.Organizations;

namespace ExternDotnetSDK
{
    public interface IKeApiClient
    {
        IAccountClient Accounts { get; }
        IDocflowsClient Docflows { get; }
        IDraftClient Drafts { get; }
        IDraftsBuilderClient DraftsBuilder { get; }
        IEventsClient Events { get; }
        IInventoryDocflowsClient InventoryDocflows { get; }
        IOrganizationsClient Organizations { get; }
    }
}