
# Props 12

## Structure

`Props12`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Description` | `string` | Optional | - |
| `ContainerLabels` | [`List<Models.FormatKey1Value1Key2Value2>`](../../doc/models/format-key-1-value-1-key-2-value-2.md) | Required | **Constraints**: *Minimum Items*: `1` |
| `ContainerTags` | `List<string>` | Required | **Constraints**: *Minimum Items*: `1`, *Pattern*: `(?!^ +$)^.+$` |

## Example (as JSON)

```json
{
  "description": null,
  "containerLabels": [
    {
      "A.+": null
    },
    {
      "A.+": null
    },
    {
      "A.+": null
    }
  ],
  "containerTags": [
    "containerTags5",
    "containerTags6",
    "containerTags7"
  ]
}
```
