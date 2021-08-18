BEGIN { 
    nextid=0
    indent="        "
}
{
    split($0, a, ","); name=a[2]; id=a[1];
    if (nextid != id) {
        missing=id-nextid
        if (nextid == 0) {}
        else if (missing > 8) {
            printf "%s// ??? = [%x..%x]\n", indent, nextid, id-1
        }
        else {
            for (i = nextid; i < id; i++) {
                printf "%s// ??? = %x\n", indent, i
            }
        }
        printf "%s%s = 0x%x,\n", indent, name, id
    } else {
        printf "%s%s,\n", indent, name;
    }
    nextid=id+1
}
