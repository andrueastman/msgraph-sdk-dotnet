---
title: "message: copy"
description: "Copy a message to a folder."
author: "abheek-das"
ms.localizationpriority: medium
ms.prod: "outlook"
doc_type: apiPageType
---

# message: copy

Namespace: microsoft.graph

Copy a message to a folder within the user's mailbox.

## Permissions

One of the following permissions is required to call this API. To learn more, including how to choose permissions, see [Permissions](/graph/permissions-reference).

| Permission type | Permissions (from least to most privileged) |
|:----------------|:--------------------------------------------|
|Delegated (work or school account) | Mail.ReadWrite    |
|Delegated (personal Microsoft account) | Mail.ReadWrite    |
|Application | Mail.ReadWrite |

## HTTP request

<!-- { "blockType": "ignored" } -->

```http
POST /me/messages/{id}/copy
POST /users/{id | userPrincipalName}/messages/{id}/copy
POST /me/mailFolders/{id}/messages/{id}/copy
POST /users/{id | userPrincipalName}/mailFolders/{id}/messages/{id}/copy
```

## Request headers

| Header | Value |
|:-------|:------|
| Authorization | `Bearer {token}`. Required. |
| Content-Type | `application/json`. Required. |

## Request body

In the request body, provide a JSON object with the following parameters.

| Parameter | Type | Description |
|:----------|:-----|:------------|
|destinationId|String|The destination folder ID, or a well-known folder name. For a list of supported well-known folder names, see [mailFolder resource type](../resources/mailfolder.md).|

## Response

If successful, this method returns `201 Created` response code and a [message](../resources/message.md) resource in the response body.

## Example

Here is an example of how to call this API.

##### Request
Here is an example of the request.

# [HTTP](#tab/http)
<!-- {
  "blockType": "request",
  "name": "message_copy"
}-->

```http
POST https://graph.microsoft.com/v1.0/me/messages/{id}/copy
Content-type: application/json

{
  "destinationId": "destinationId-value"
}
```

# [C#](#tab/csharp)

```csharp

GraphServiceClient graphClient = new GraphServiceClient( authProvider );

var destinationId = "destinationId-value";

await graphClient.Me.Messages["{message-id}"]
	.Copy(destinationId)
	.Request()
	.PostAsync();

```


 For details about how to [add the SDK](/graph/sdks/sdk-installation) to your project and [create an authProvider](/graph/sdks/choose-authentication-providers) instance, see the [SDK documentation](/graph/sdks/sdks-overview).

