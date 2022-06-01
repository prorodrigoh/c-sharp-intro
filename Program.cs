// var stranger = "Rodrigo";
// string friend = "Darie";
// Console.WriteLine("Hello, " + stranger + ". It is me, " + friend);

// // template literal
// stranger = "Another";
// int one = 1;
// Console.WriteLine($"Hello, {stranger} {one}");
// Console.WriteLine(stranger.IndexOf("t"));

// int a=10, b=20, c=15;
// int isum = a+b+c;

// double n = 5.0, d = 3.0;
// double div = n / d;

// int maxI = int.MaxValue;
// double maxD = double.MaxValue;

// Console.WriteLine($"The sum of {a}, {b} & {c} is {isum}");
// Console.WriteLine($"Division of double by double is a double {div}");
// Console.WriteLine(maxI);
// Console.WriteLine(maxD);
// Console.WriteLine("----- // ----- // ----- // ----- // ----- // ----- // -----");


var arr1 = new int[10];
int[] arr2 = new int[] {1,2,3,4};

arr1[0] = 100;

Console.WriteLine(arr1[0]);
Console.WriteLine(arr2[0]);

for (var i=0; i<arr1.Length; i++){
    Console.WriteLine($"Array Index {i} Element Value {arr1[i]}");
};

Console.WriteLine("----- // ----- // ----- // ----- // ----- // ----- // -----");

for (var i=0; i<arr2.Length; i++){
    Console.WriteLine($"Array Index {i} Element Value {arr2[i]}");
};

Console.WriteLine("----- // ----- // ----- // ----- // ----- // ----- // -----");

foreach(var el in arr1){
    Console.WriteLine(el);
}