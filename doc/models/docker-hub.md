
# Docker Hub

## Structure

`DockerHub`

## Inherits From

[`Data94`](../../doc/models/data-94.md)

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Credentials` | [`Models.Credentials20`](../../doc/models/credentials-20.md) | Required | - |
| `RegistryDomain` | `string` | Required, Constant | **Default**: `"index.docker.io"` |
| `LimitNumImg` | [`Models.LimitNumberOfImagesPerRepoEnum?`](../../doc/models/limit-number-of-images-per-repo-enum.md) | Optional | **Default**: `LimitNumberOfImagesPerRepoEnum.Enum_5` |
| `LimitByRep` | `List<string>` | Optional | - |
| `LimitByTag` | `List<string>` | Optional | - |
| `LimitByLabel` | [`List<Models.LimitByLabelSOptional>`](../../doc/models/limit-by-label-s-optional.md) | Optional | - |

## Example (as JSON)

```json
{
  "credentials": null,
  "registryDomain": "index.docker.io"
}
```
