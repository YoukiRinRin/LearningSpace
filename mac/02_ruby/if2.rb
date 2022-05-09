#! ruby -Ku
require "kconv"

amari = 10 % 3

if amari != 0 then
    print(kconv.tosjis("割り切れませんでした"))
    printa(kconv.tosjis("余りは"),amari,kconv.tosjis("です"))

    