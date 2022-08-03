
# Alert Channels Gcp Pubsub Response Schema

## Structure

`AlertChannelsGcpPubsubResponseSchema`

## Inherits From

[`AlertChannelsResponseSchema`](../../doc/models/alert-channels-response-schema.md)

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Name` | `string` | Required | **Constraints**: *Minimum Length*: `1`, *Pattern*: `(?!^ +$)^.+$` |
| `Enabled` | `double` | Required | **Constraints**: `>= 0`, `<= 1` |
| `Data` | [`Models.Data5`](../../doc/models/data-5.md) | Required | - |
| `IsOrg` | `double?` | Optional | **Default**: `0`<br>**Constraints**: `>= 0`, `<= 1` |
| `Props` | `object` | Optional | - |

## Example (as JSON)

```json
{
  "name": "name0",
  "enabled": 18.58,
  "data": {
    "issueGrouping": null,
    "credentials": {
      "clientId": "clientId8",
      "privateKeyId": "privateKeyId0",
      "clientEmail": "clientEmail4",
      "privateKey": "privateKey6"
    },
    "projectId": "projectId0",
    "topicId": "topicId8"
  },
  "isOrg": null,
  "props": null,
  "type": "GcpPubsub"
}
```
