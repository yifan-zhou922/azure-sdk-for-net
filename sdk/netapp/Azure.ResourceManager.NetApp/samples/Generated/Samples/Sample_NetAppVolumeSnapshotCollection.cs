// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.NetApp;

namespace Azure.ResourceManager.NetApp.Samples
{
    public partial class Sample_NetAppVolumeSnapshotCollection
    {
        // Snapshots_List
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_SnapshotsList()
        {
            // Generated from example definition: specification/netapp/resource-manager/Microsoft.NetApp/stable/2022-11-01/examples/Snapshots_List.json
            // this example is just showing the usage of "Snapshots_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetAppVolumeResource created on azure
            // for more information of creating NetAppVolumeResource, please refer to the document of NetAppVolumeResource
            string subscriptionId = "D633CC2E-722B-4AE1-B636-BBD9E4C60ED9";
            string resourceGroupName = "myRG";
            string accountName = "account1";
            string poolName = "pool1";
            string volumeName = "volume1";
            ResourceIdentifier netAppVolumeResourceId = NetAppVolumeResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, poolName, volumeName);
            NetAppVolumeResource netAppVolume = client.GetNetAppVolumeResource(netAppVolumeResourceId);

            // get the collection of this NetAppVolumeSnapshotResource
            NetAppVolumeSnapshotCollection collection = netAppVolume.GetNetAppVolumeSnapshots();

            // invoke the operation and iterate over the result
            await foreach (NetAppVolumeSnapshotResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                NetAppVolumeSnapshotData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Snapshots_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_SnapshotsGet()
        {
            // Generated from example definition: specification/netapp/resource-manager/Microsoft.NetApp/stable/2022-11-01/examples/Snapshots_Get.json
            // this example is just showing the usage of "Snapshots_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetAppVolumeResource created on azure
            // for more information of creating NetAppVolumeResource, please refer to the document of NetAppVolumeResource
            string subscriptionId = "D633CC2E-722B-4AE1-B636-BBD9E4C60ED9";
            string resourceGroupName = "myRG";
            string accountName = "account1";
            string poolName = "pool1";
            string volumeName = "volume1";
            ResourceIdentifier netAppVolumeResourceId = NetAppVolumeResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, poolName, volumeName);
            NetAppVolumeResource netAppVolume = client.GetNetAppVolumeResource(netAppVolumeResourceId);

            // get the collection of this NetAppVolumeSnapshotResource
            NetAppVolumeSnapshotCollection collection = netAppVolume.GetNetAppVolumeSnapshots();

            // invoke the operation
            string snapshotName = "snapshot1";
            NetAppVolumeSnapshotResource result = await collection.GetAsync(snapshotName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetAppVolumeSnapshotData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Snapshots_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_SnapshotsGet()
        {
            // Generated from example definition: specification/netapp/resource-manager/Microsoft.NetApp/stable/2022-11-01/examples/Snapshots_Get.json
            // this example is just showing the usage of "Snapshots_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetAppVolumeResource created on azure
            // for more information of creating NetAppVolumeResource, please refer to the document of NetAppVolumeResource
            string subscriptionId = "D633CC2E-722B-4AE1-B636-BBD9E4C60ED9";
            string resourceGroupName = "myRG";
            string accountName = "account1";
            string poolName = "pool1";
            string volumeName = "volume1";
            ResourceIdentifier netAppVolumeResourceId = NetAppVolumeResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, poolName, volumeName);
            NetAppVolumeResource netAppVolume = client.GetNetAppVolumeResource(netAppVolumeResourceId);

            // get the collection of this NetAppVolumeSnapshotResource
            NetAppVolumeSnapshotCollection collection = netAppVolume.GetNetAppVolumeSnapshots();

            // invoke the operation
            string snapshotName = "snapshot1";
            bool result = await collection.ExistsAsync(snapshotName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Snapshots_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_SnapshotsGet()
        {
            // Generated from example definition: specification/netapp/resource-manager/Microsoft.NetApp/stable/2022-11-01/examples/Snapshots_Get.json
            // this example is just showing the usage of "Snapshots_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetAppVolumeResource created on azure
            // for more information of creating NetAppVolumeResource, please refer to the document of NetAppVolumeResource
            string subscriptionId = "D633CC2E-722B-4AE1-B636-BBD9E4C60ED9";
            string resourceGroupName = "myRG";
            string accountName = "account1";
            string poolName = "pool1";
            string volumeName = "volume1";
            ResourceIdentifier netAppVolumeResourceId = NetAppVolumeResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, poolName, volumeName);
            NetAppVolumeResource netAppVolume = client.GetNetAppVolumeResource(netAppVolumeResourceId);

            // get the collection of this NetAppVolumeSnapshotResource
            NetAppVolumeSnapshotCollection collection = netAppVolume.GetNetAppVolumeSnapshots();

            // invoke the operation
            string snapshotName = "snapshot1";
            NullableResponse<NetAppVolumeSnapshotResource> response = await collection.GetIfExistsAsync(snapshotName);
            NetAppVolumeSnapshotResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                NetAppVolumeSnapshotData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // Snapshots_Create
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_SnapshotsCreate()
        {
            // Generated from example definition: specification/netapp/resource-manager/Microsoft.NetApp/stable/2022-11-01/examples/Snapshots_Create.json
            // this example is just showing the usage of "Snapshots_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetAppVolumeResource created on azure
            // for more information of creating NetAppVolumeResource, please refer to the document of NetAppVolumeResource
            string subscriptionId = "D633CC2E-722B-4AE1-B636-BBD9E4C60ED9";
            string resourceGroupName = "myRG";
            string accountName = "account1";
            string poolName = "pool1";
            string volumeName = "volume1";
            ResourceIdentifier netAppVolumeResourceId = NetAppVolumeResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, poolName, volumeName);
            NetAppVolumeResource netAppVolume = client.GetNetAppVolumeResource(netAppVolumeResourceId);

            // get the collection of this NetAppVolumeSnapshotResource
            NetAppVolumeSnapshotCollection collection = netAppVolume.GetNetAppVolumeSnapshots();

            // invoke the operation
            string snapshotName = "snapshot1";
            NetAppVolumeSnapshotData data = new NetAppVolumeSnapshotData(new AzureLocation("eastus"));
            ArmOperation<NetAppVolumeSnapshotResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, snapshotName, data);
            NetAppVolumeSnapshotResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetAppVolumeSnapshotData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
