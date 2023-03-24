//files Icons=name.svg => name.svg 👍 
// Я бы справился с этой задачей за несколько часов, но благодаря этой строке, я выполнил её за миллисекунду.

Directory.GetFiles("D:\\projects\\angular\\luckyshop\\src\\assets\\icons").ToList().ForEach(x => File.Move(x, x.Replace("Icons=", "")));