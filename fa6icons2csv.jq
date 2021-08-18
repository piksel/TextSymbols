to_entries | map(
    "0x" +
    (.value.unicode | tostring | if (8 > length) then ((8 - length) * "0") + . else . end)
    + "," 
    + (
        "_" + .key | gsub (
            # Convert snake_case to UpperCase (prepended `_` since `_snake` => `Snake`)
            "(?=.*?)[_-](?<tchar>[a-zA-Z0-9])";
            .tchar | ascii_upcase
        ) | gsub (
            "^(?<digits>[0-9]+)";
            "D" + .digits
        )
    ) 
) | join("\n")