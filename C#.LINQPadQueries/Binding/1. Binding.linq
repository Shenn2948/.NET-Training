<Query Kind="Statements" />

////http://blogs.msdn.com/b/ruericlippert/archive/2012/03/04/what-is-quot-binding-quot-and-what-makes-it-late.aspx
////
//По определению, компилятор – это такое устройство, которое принимает текст, 
//написанный на одном языке, и выдает код на другом языке, «который означает то же». 
//например,  компилятор, который принимает на вход текст на языке C# и 
//выдает CIL (*). Все важные задачи, выполняемые компилятором можно разделить
//на три крупные группы:
//
// - Синтаксический (лексика и грамматика) анализ входного текста
// - Семантический анализ синтаксиса
// - Генерация выходного текста 
//
//Синтаксический анализ входного текста ничего не знает о значении анализируемого текста;
//синтаксический анализ беспокоится, прежде всего, о лексической структуре 
//программы (т.е. о границах комментариев, идентификаторах, операторах и т.п.), 
//а затем по этой лексической структуре определяется грамматическая 
//структура программы: границы классов, методов, операторов, выражений и т.п.

//Затем семантический анализатор берет результаты синтаксического анализатора и 
//связывает значения различных синтаксических элементов. Например, когда написано:
//
//	class X {} 
//	class B {} 
//	class D : B 
//	{ 
//  	public static void X() { } 
//  	public static void Y() { X(); } 
//	}
//
//то синтаксический анализатор определяет наличие трех классов, что один из них
//содержит два метода, второй метод содержит оператор, который является выражением 
//вызова метода. Семантический анализатор определяет, что X в выражении X();
//ссылается на метод D.X(), а не, скажем, на тип X, объявленный выше. 

//Это и есть пример «связывания» в наиболее широком смысле этого слова: 
//связывание – это ассоциация синтаксического элемента, содержащего имя метода,
//с логической частью программы.
//«связывание» – это любая ассоциация некоторого фрагмента
//синтаксического дерева с некоторым логическим элементом программы






