## Callback
Callback used to retrieve an information for Uiza to your server, so you can have a trigger notice about an entity is upload completed and .
See details [here](https://docs.uiza.io/#callback).

## Create Callback
This API will allow you setup a callback to your server when an entity is completed for upload or public
See details [here](https://docs.uiza.io/#create-a-callback).

```Cshard
using Uiza.Net.Services;

var createResult = UizaServices.Callback.Create(new CreateCallbackParameter()
{
    Url = "https://callback-url.uiza.co",
    Method = CallbackMethodTypes.Post,
});

Console.WriteLine(string.Format("Create New Callback Id = {0} Success", createResult.Data.id));
```

## Retrieve a callback
Retrieves the details of an existing callback.
See details [here](https://docs.uiza.io/#retrieve-a-callback).

```Cshard
using Uiza.Net.Services;

UizaConfiguration.SetupUiza(new UizaConfigOptions
{
	ApiKey = "your-ApiKey",
	ApiBase = "your-workspace-api-domain.uiza.co"
});

var retrieveResult = UizaServices.Callback.Retrieve((string)createResult.Data.id);
Console.WriteLine(string.Format("Get Callback Id = {0} Success", retrieveResult.Data.id));
```

## Update a callback
This API will allow you setup a callback to your server when an entity is completed for upload or public
See details [here](https://docs.uiza.io/#update-a-callback).

```Cshard
using Uiza.Net.Services;

UizaConfiguration.SetupUiza(new UizaConfigOptions
{
	ApiKey = "your-ApiKey",
	ApiBase = "your-workspace-api-domain.uiza.co"
});

var resultUpdate = UizaServices.Callback.Update(new UpdateCallbackParameter()
{
    Id = createResult.Data.id,
    Url = "https://callback-url.uiza.co/update",
    Method = CallbackMethodTypes.Post
});

Console.WriteLine(string.Format("Update Callback Id = {0} Success", resultUpdate.Data.id));
```

## Delete a callback
Delete an existing callback.
See details [here](https://docs.uiza.io/#delete-a-callback).

```Cshard
using Uiza.Net.Services;

UizaConfiguration.SetupUiza(new UizaConfigOptions
{
	ApiKey = "your-ApiKey",
	ApiBase = "your-workspace-api-domain.uiza.co"
});
var resultDelete = UizaServices.Callback.Delete((string)createResult.Data.id);
Console.WriteLine(string.Format("Delete Callback Id = {0} Success", resultUpdate.Data.id));
```



