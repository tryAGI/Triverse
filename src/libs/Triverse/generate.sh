#!/usr/bin/env bash
set -euo pipefail

# OpenAPI spec: locally maintained from https://docs.triverse.ai/

dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
autosdk generate openapi.yaml \
  --namespace Triverse \
  --clientClassName TriverseClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations
