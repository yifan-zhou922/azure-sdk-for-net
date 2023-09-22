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
using Azure.ResourceManager.DevTestLabs;
using Azure.ResourceManager.DevTestLabs.Models;

namespace Azure.ResourceManager.DevTestLabs.Samples
{
    public partial class Sample_DevTestLabEnvironmentCollection
    {
        // Environments_List
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_EnvironmentsList()
        {
            // Generated from example definition: specification/devtestlabs/resource-manager/Microsoft.DevTestLab/stable/2018-09-15/examples/Environments_List.json
            // this example is just showing the usage of "Environments_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DevTestLabUserResource created on azure
            // for more information of creating DevTestLabUserResource, please refer to the document of DevTestLabUserResource
            string subscriptionId = "{subscriptionId}";
            string resourceGroupName = "resourceGroupName";
            string labName = "{labName}";
            string userName = "@me";
            ResourceIdentifier devTestLabUserResourceId = DevTestLabUserResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, labName, userName);
            DevTestLabUserResource devTestLabUser = client.GetDevTestLabUserResource(devTestLabUserResourceId);

            // get the collection of this DevTestLabEnvironmentResource
            DevTestLabEnvironmentCollection collection = devTestLabUser.GetDevTestLabEnvironments();

            // invoke the operation and iterate over the result
            await foreach (DevTestLabEnvironmentResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                DevTestLabEnvironmentData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Environments_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_EnvironmentsGet()
        {
            // Generated from example definition: specification/devtestlabs/resource-manager/Microsoft.DevTestLab/stable/2018-09-15/examples/Environments_Get.json
            // this example is just showing the usage of "Environments_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DevTestLabUserResource created on azure
            // for more information of creating DevTestLabUserResource, please refer to the document of DevTestLabUserResource
            string subscriptionId = "{subscriptionId}";
            string resourceGroupName = "resourceGroupName";
            string labName = "{labName}";
            string userName = "@me";
            ResourceIdentifier devTestLabUserResourceId = DevTestLabUserResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, labName, userName);
            DevTestLabUserResource devTestLabUser = client.GetDevTestLabUserResource(devTestLabUserResourceId);

            // get the collection of this DevTestLabEnvironmentResource
            DevTestLabEnvironmentCollection collection = devTestLabUser.GetDevTestLabEnvironments();

            // invoke the operation
            string name = "{environmentName}";
            DevTestLabEnvironmentResource result = await collection.GetAsync(name);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DevTestLabEnvironmentData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Environments_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_EnvironmentsGet()
        {
            // Generated from example definition: specification/devtestlabs/resource-manager/Microsoft.DevTestLab/stable/2018-09-15/examples/Environments_Get.json
            // this example is just showing the usage of "Environments_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DevTestLabUserResource created on azure
            // for more information of creating DevTestLabUserResource, please refer to the document of DevTestLabUserResource
            string subscriptionId = "{subscriptionId}";
            string resourceGroupName = "resourceGroupName";
            string labName = "{labName}";
            string userName = "@me";
            ResourceIdentifier devTestLabUserResourceId = DevTestLabUserResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, labName, userName);
            DevTestLabUserResource devTestLabUser = client.GetDevTestLabUserResource(devTestLabUserResourceId);

            // get the collection of this DevTestLabEnvironmentResource
            DevTestLabEnvironmentCollection collection = devTestLabUser.GetDevTestLabEnvironments();

            // invoke the operation
            string name = "{environmentName}";
            bool result = await collection.ExistsAsync(name);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Environments_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_EnvironmentsGet()
        {
            // Generated from example definition: specification/devtestlabs/resource-manager/Microsoft.DevTestLab/stable/2018-09-15/examples/Environments_Get.json
            // this example is just showing the usage of "Environments_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DevTestLabUserResource created on azure
            // for more information of creating DevTestLabUserResource, please refer to the document of DevTestLabUserResource
            string subscriptionId = "{subscriptionId}";
            string resourceGroupName = "resourceGroupName";
            string labName = "{labName}";
            string userName = "@me";
            ResourceIdentifier devTestLabUserResourceId = DevTestLabUserResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, labName, userName);
            DevTestLabUserResource devTestLabUser = client.GetDevTestLabUserResource(devTestLabUserResourceId);

            // get the collection of this DevTestLabEnvironmentResource
            DevTestLabEnvironmentCollection collection = devTestLabUser.GetDevTestLabEnvironments();

            // invoke the operation
            string name = "{environmentName}";
            NullableResponse<DevTestLabEnvironmentResource> response = await collection.GetIfExistsAsync(name);
            DevTestLabEnvironmentResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                DevTestLabEnvironmentData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // Environments_CreateOrUpdate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_EnvironmentsCreateOrUpdate()
        {
            // Generated from example definition: specification/devtestlabs/resource-manager/Microsoft.DevTestLab/stable/2018-09-15/examples/Environments_CreateOrUpdate.json
            // this example is just showing the usage of "Environments_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DevTestLabUserResource created on azure
            // for more information of creating DevTestLabUserResource, please refer to the document of DevTestLabUserResource
            string subscriptionId = "{subscriptionId}";
            string resourceGroupName = "resourceGroupName";
            string labName = "{labName}";
            string userName = "@me";
            ResourceIdentifier devTestLabUserResourceId = DevTestLabUserResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, labName, userName);
            DevTestLabUserResource devTestLabUser = client.GetDevTestLabUserResource(devTestLabUserResourceId);

            // get the collection of this DevTestLabEnvironmentResource
            DevTestLabEnvironmentCollection collection = devTestLabUser.GetDevTestLabEnvironments();

            // invoke the operation
            string name = "{environmentName}";
            DevTestLabEnvironmentData data = new DevTestLabEnvironmentData(new AzureLocation("placeholder"))
            {
                DeploymentProperties = new DevTestLabEnvironmentDeployment()
                {
                    ArmTemplateId = new ResourceIdentifier("/subscriptions/{subscriptionId}/resourceGroups/resourceGroupName/providers/Microsoft.DevTestLab/labs/{labName}/artifactSources/{artifactSourceName}/armTemplates/{armTemplateName}"),
                    Parameters =
{
},
                },
            };
            ArmOperation<DevTestLabEnvironmentResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, name, data);
            DevTestLabEnvironmentResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DevTestLabEnvironmentData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
