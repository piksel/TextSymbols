#!/bin/bash

SOURCE_JSON=${1:-fontawesome6/pro/metadata/icons.json}
TARGET_CS=${2:-TextSymbols/FontAwesome6.cs}
ENUM_NAME=Fa6
NAMESPACE=Piksel.TextSymbols

if [[ ! -f "$SOURCE_JSON" ]]; then
    echo "No source JSON file found" >&2
    echo "Usage: $0 <source>" >&2
    exit 1
fi

if ! command -v "jq" &> /dev/null; then
    echo "Missing dependency \"jq\": https://stedolan.github.io/jq/" >&2
    exit 1
fi

cat > $TARGET_CS <<EOF
namespace ${NAMESPACE}
{
    public static class ${ENUM_NAME}Extensions
    {
        public static TextSymbol TextSymbol(this ${ENUM_NAME} symbol) 
          => new TextSymbol(char.ConvertFromUtf32((int)symbol));
    }

    public partial record TextSymbol {
      public static implicit operator TextSymbol(${ENUM_NAME} fa6) => fa6.TextSymbol();
    }

    public enum ${ENUM_NAME}: int
    {
EOF

cat $SOURCE_JSON | \
    jq -rf fa6icons2csv.jq | \
    sort | \
    awk -n -f csv2enum.awk >> $TARGET_CS

cat >> $TARGET_CS <<EOF
    }
}
EOF