<Query Kind="Program" />

public struct SomeValType
{
	public static int xStatic = 1;
	
	public int xInstance;
	
	static SomeValType() 
		=> Console.WriteLine("Static ctor for struct works!");
}

public class SomeRefType
{
	public static int xStatic = 1;
	
	public int xInstance = 2;
	
	public SomeRefType() 
		=> Console.WriteLine("Instance ctor for class works!");
		
	static SomeRefType() 
		=> Console.WriteLine("Static ctor for class works!");
}

void Main()
{
	SomeValType a = new SomeValType();
	SomeValType.xStatic = 0;
	
	SomeRefType.xStatic = 90;
	SomeRefType b = new SomeRefType();
}