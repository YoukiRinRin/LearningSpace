year =  ARGV[0].to_i

if year % 100 == 0 && year % 400 != 0
    print year,"年はうるう年ではありません"
elsif year % 4 == 0
    print year,"年はうるう年です"
else
    print year,"年はうるう年ではありません"
end

n = rand(1..100)
m = 0

loop do
    puts"入力をお願いします。"
    m = gets.to_i

    if m > n 
        puts "もっと小さいです"
    elsif m < n
        puts"もっと大きいです"
    else
        break
    end
end
puts"正解です。"

