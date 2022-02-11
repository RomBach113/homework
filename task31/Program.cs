//31. задатьмассив из 8 элементов и вывести их на экран
//int[] a={1,2,3,4,5,6,7,8,9};

//System.Console.WriteLine(a[0]);
//System.Console.WriteLine(a[9]);

double[] a=new double[20];

for(int i=0;i<a.Length;i++)
a[i]=new Random().Next(0,100);

for(int i=0;i<a.Length;i++)
    System.Console.Write($"{a[i]} ");