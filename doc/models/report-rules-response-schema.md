
# Report Rules Response Schema

## Structure

`ReportRulesResponseSchema`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Filters` | [`Models.Filters6`](../../doc/models/filters-6.md) | Required | - |
| `IntgGuidList` | `List<string>` | Required | **Constraints**: *Minimum Items*: `1`, *Unique Items Required* |
| `ReportNotificationTypes` | [`Models.ReportNotificationTypes`](../../doc/models/report-notification-types.md) | Required | - |
| `Type` | `string` | Required, Constant | **Default**: `"Report"` |
| `McGuid` | `string` | Optional | - |

## Example (as JSON)

```json
{
  "filters": null,
  "intgGuidList": null,
  "reportNotificationTypes": null,
  "type": "Report"
}
```
