#! ruby -Ku
require "kconv"

num = 0
print(Kconv.tosjis("繰り返し開始\n"))

while num < 5 do
  print("num = ", num, "\n")
  num = num + 1
end
print(Kconv.tosjis("繰り返し終了\n"))
