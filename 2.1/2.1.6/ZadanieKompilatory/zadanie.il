// C:\Users\Paweł\Documents\GitHub\dotNet\2.1\2.1.6\ZadanieKompilatory\zadanie\zadanie\bin\Debug\zadanie.exe

.assembly extern mscorlib
{
	.publickeytoken = (
		b7 7a 5c 56 19 34 e0 89
	)
	.ver 4:0:0:0
}
.assembly zadanie
{
	.custom instance void [mscorlib]System.Reflection.AssemblyCopyrightAttribute::.ctor(string) = (
		01 00 12 43 6f 70 79 72 69 67 68 74 20 c2 a9 20
		20 32 30 31 34 00 00
	)
	.custom instance void [mscorlib]System.Runtime.CompilerServices.RuntimeCompatibilityAttribute::.ctor() = (
		01 00 01 00 54 02 16 57 72 61 70 4e 6f 6e 45 78
		63 65 70 74 69 6f 6e 54 68 72 6f 77 73 01
	)
	.custom instance void [mscorlib]System.Reflection.AssemblyTitleAttribute::.ctor(string) = (
		01 00 07 7a 61 64 61 6e 69 65 00 00
	)
	.custom instance void [mscorlib]System.Reflection.AssemblyDescriptionAttribute::.ctor(string) = (
		01 00 00 00 00
	)
	.custom instance void [mscorlib]System.Reflection.AssemblyConfigurationAttribute::.ctor(string) = (
		01 00 00 00 00
	)
	.custom instance void [mscorlib]System.Reflection.AssemblyCompanyAttribute::.ctor(string) = (
		01 00 00 00 00
	)
	.custom instance void [mscorlib]System.Reflection.AssemblyProductAttribute::.ctor(string) = (
		01 00 07 7a 61 64 61 6e 69 65 00 00
	)
	.custom instance void [mscorlib]System.Runtime.Versioning.TargetFrameworkAttribute::.ctor(string) = (
		01 00 1a 2e 4e 45 54 46 72 61 6d 65 77 6f 72 6b
		2c 56 65 72 73 69 6f 6e 3d 76 34 2e 35 01 00 54
		0e 14 46 72 61 6d 65 77 6f 72 6b 44 69 73 70 6c
		61 79 4e 61 6d 65 12 2e 4e 45 54 20 46 72 61 6d
		65 77 6f 72 6b 20 34 2e 35
	)
	.custom instance void [mscorlib]System.Reflection.AssemblyTrademarkAttribute::.ctor(string) = (
		01 00 00 00 00
	)
	.custom instance void [mscorlib]System.Runtime.InteropServices.ComVisibleAttribute::.ctor(bool) = (
		01 00 00 00 00
	)
	.custom instance void [mscorlib]System.Runtime.InteropServices.GuidAttribute::.ctor(string) = (
		01 00 24 64 61 62 31 34 38 66 66 2d 30 66 35 32
		2d 34 31 33 37 2d 39 64 32 36 2d 61 65 64 32 64
		31 33 39 31 39 37 34 00 00
	)
	.custom instance void [mscorlib]System.Reflection.AssemblyFileVersionAttribute::.ctor(string) = (
		01 00 07 31 2e 30 2e 30 2e 30 00 00
	)
	.custom instance void [mscorlib]System.Diagnostics.DebuggableAttribute::.ctor(valuetype [mscorlib]System.Diagnostics.DebuggableAttribute/DebuggingModes) = (
		01 00 07 01 00 00 00 00
	)
	.custom instance void [mscorlib]System.Runtime.CompilerServices.CompilationRelaxationsAttribute::.ctor(int32) = (
		01 00 08 00 00 00 00 00
	)
	.hash algorithm 0x00008004 // SHA1
	.ver 1:0:0:0
}

.module zadanie.exe
// MVID: {F34CFB3C-BCFD-4D82-9269-A2C45F7BD014}
.corflags 0x00020003 // ILOnly, Required32Bit, Preferred32Bit


.class private auto ansi '<Module>'
{
} // end of class <Module>

.class private auto ansi beforefieldinit zadanie.Program
	extends [mscorlib]System.Object
{
	// Methods
	.method private hidebysig static 
		void Main (
			string[] args
		) cil managed 
	{
		// Method begins at RVA 0x2050
		// Code size 288 (0x120)
		.maxstack 3
		.entrypoint
		.locals init (
			[0] class zadanie.ListaKolorow mojaListaKolorow,
			[1] int32 i,
			[2] int32 zmienna,
			[3] bool CS$4$0000,
			[4] int32 CS$4$0001
		)

		IL_0000: nop
		IL_0001: ldstr "Moja Lista"
		IL_0006: newobj instance void zadanie.ListaKolorow::.ctor(string)
		IL_000b: stloc.0
		IL_000c: ldc.i4.0
		IL_000d: stloc.1
		IL_000e: br.s IL_0022
		// loop start (head: IL_0022)
			IL_0010: nop
			IL_0011: ldloc.0
			IL_0012: ldstr "brak"
			IL_0017: callvirt instance void zadanie.ListaKolorow::dodajKolor(string)
			IL_001c: nop
			IL_001d: nop
			IL_001e: ldloc.1
			IL_001f: ldc.i4.1
			IL_0020: add
			IL_0021: stloc.1

			IL_0022: ldloc.1
			IL_0023: ldc.i4.s 10
			IL_0025: cgt
			IL_0027: ldc.i4.0
			IL_0028: ceq
			IL_002a: stloc.3
			IL_002b: ldloc.3
			IL_002c: brtrue.s IL_0010
		// end loop

		IL_002e: ldloc.0
		IL_002f: ldc.i4.5
		IL_0030: callvirt instance string zadanie.ListaKolorow::get_Item(int32)
		IL_0035: call void [mscorlib]System.Console::WriteLine(string)
		IL_003a: nop
		IL_003b: ldc.i4.0
		IL_003c: stloc.1
		IL_003d: br IL_00e5
		// loop start (head: IL_00e5)
			IL_0042: nop
			IL_0043: ldloc.1
			IL_0044: ldc.i4.3
			IL_0045: rem
			IL_0046: stloc.2
			IL_0047: ldloc.2
			IL_0048: call void [mscorlib]System.Console::WriteLine(int32)
			IL_004d: nop
			IL_004e: ldloc.2
			IL_004f: stloc.s CS$4$0001
			IL_0051: ldloc.s CS$4$0001
			IL_0053: switch (IL_0066, IL_0075, IL_00ad)

			IL_0064: br.s IL_00e0

			IL_0066: ldloc.0
			IL_0067: ldloc.1
			IL_0068: ldstr "kolor zerowy"
			IL_006d: callvirt instance void zadanie.ListaKolorow::set_Item(int32, string)
			IL_0072: nop
			IL_0073: br.s IL_00e0

			IL_0075: ldloc.0
			IL_0076: ldloc.1
			IL_0077: callvirt instance string zadanie.ListaKolorow::get_Item(int32)
			IL_007c: ldstr "brak"
			IL_0081: call bool [mscorlib]System.String::op_Equality(string, string)
			IL_0086: ldc.i4.0
			IL_0087: ceq
			IL_0089: stloc.3
			IL_008a: ldloc.3
			IL_008b: brtrue.s IL_009e

			IL_008d: nop
			IL_008e: ldloc.0
			IL_008f: ldloc.1
			IL_0090: ldstr " kolor z pozycji pierwszej"
			IL_0095: callvirt instance void zadanie.ListaKolorow::set_Item(int32, string)
			IL_009a: nop
			IL_009b: nop
			IL_009c: br.s IL_00ab

			IL_009e: nop
			IL_009f: ldstr "chyba cos jest nie tak"
			IL_00a4: call void [mscorlib]System.Console::WriteLine(string)
			IL_00a9: nop
			IL_00aa: nop

			IL_00ab: br.s IL_00e0

			IL_00ad: br.s IL_00c9
			// loop start (head: IL_00c9)
				IL_00af: nop
				IL_00b0: ldloc.0
				IL_00b1: ldloc.1
				IL_00b2: ldstr "kolor z pozycji drugiej"
				IL_00b7: callvirt instance void zadanie.ListaKolorow::set_Item(int32, string)
				IL_00bc: nop
				IL_00bd: ldstr "Powinno byc wypisane raz"
				IL_00c2: call void [mscorlib]System.Console::WriteLine(string)
				IL_00c7: nop
				IL_00c8: nop

				IL_00c9: ldloc.0
				IL_00ca: ldloc.1
				IL_00cb: callvirt instance string zadanie.ListaKolorow::get_Item(int32)
				IL_00d0: ldstr "kolor z pozycji drugiej"
				IL_00d5: call bool [mscorlib]System.String::op_Inequality(string, string)
				IL_00da: stloc.3
				IL_00db: ldloc.3
				IL_00dc: brtrue.s IL_00af
			// end loop

			IL_00de: br.s IL_00e0

			IL_00e0: nop
			IL_00e1: ldloc.1
			IL_00e2: ldc.i4.1
			IL_00e3: add
			IL_00e4: stloc.1

			IL_00e5: ldloc.1
			IL_00e6: ldc.i4.s 10
			IL_00e8: cgt
			IL_00ea: ldc.i4.0
			IL_00eb: ceq
			IL_00ed: stloc.3
			IL_00ee: ldloc.3
			IL_00ef: brtrue IL_0042
		// end loop

		IL_00f4: ldloc.0
		IL_00f5: callvirt instance string zadanie.ListaKolorow::get_name()
		IL_00fa: ldstr "Moja Lista"
		IL_00ff: call bool [mscorlib]System.String::op_Equality(string, string)
		IL_0104: ldc.i4.0
		IL_0105: ceq
		IL_0107: stloc.3
		IL_0108: ldloc.3
		IL_0109: brtrue.s IL_0119

		IL_010b: nop
		IL_010c: ldloc.0
		IL_010d: ldstr "Moja Lista Kolorow"
		IL_0112: callvirt instance void zadanie.ListaKolorow::set_name(string)
		IL_0117: nop
		IL_0118: nop

		IL_0119: call valuetype [mscorlib]System.ConsoleKeyInfo [mscorlib]System.Console::ReadKey()
		IL_011e: pop
		IL_011f: ret
	} // end of method Program::Main

	.method public hidebysig specialname rtspecialname 
		instance void .ctor () cil managed 
	{
		// Method begins at RVA 0x217c
		// Code size 7 (0x7)
		.maxstack 8

		IL_0000: ldarg.0
		IL_0001: call instance void [mscorlib]System.Object::.ctor()
		IL_0006: ret
	} // end of method Program::.ctor

} // end of class zadanie.Program

.class private auto ansi beforefieldinit zadanie.ListaKolorow
	extends [mscorlib]System.Object
{
	.custom instance void [mscorlib]System.Reflection.DefaultMemberAttribute::.ctor(string) = (
		01 00 04 49 74 65 6d 00 00
	)
	// Fields
	.field private string nazwaListy
	.field private class [mscorlib]System.Collections.Generic.List`1<string> list

	// Methods
	.method public hidebysig specialname 
		instance string get_name () cil managed 
	{
		// Method begins at RVA 0x2184
		// Code size 12 (0xc)
		.maxstack 1
		.locals init (
			[0] string CS$1$0000
		)

		IL_0000: nop
		IL_0001: ldarg.0
		IL_0002: ldfld string zadanie.ListaKolorow::nazwaListy
		IL_0007: stloc.0
		IL_0008: br.s IL_000a

		IL_000a: ldloc.0
		IL_000b: ret
	} // end of method ListaKolorow::get_name

	.method public hidebysig specialname 
		instance void set_name (
			string 'value'
		) cil managed 
	{
		// Method begins at RVA 0x219c
		// Code size 9 (0x9)
		.maxstack 8

		IL_0000: nop
		IL_0001: ldarg.0
		IL_0002: ldarg.1
		IL_0003: stfld string zadanie.ListaKolorow::nazwaListy
		IL_0008: ret
	} // end of method ListaKolorow::set_name

	.method public hidebysig specialname 
		instance string get_Item (
			int32 indeks
		) cil managed 
	{
		// Method begins at RVA 0x21a8
		// Code size 18 (0x12)
		.maxstack 2
		.locals init (
			[0] string CS$1$0000
		)

		IL_0000: nop
		IL_0001: ldarg.0
		IL_0002: ldfld class [mscorlib]System.Collections.Generic.List`1<string> zadanie.ListaKolorow::list
		IL_0007: ldarg.1
		IL_0008: callvirt instance !0 class [mscorlib]System.Collections.Generic.List`1<string>::get_Item(int32)
		IL_000d: stloc.0
		IL_000e: br.s IL_0010

		IL_0010: ldloc.0
		IL_0011: ret
	} // end of method ListaKolorow::get_Item

	.method public hidebysig specialname 
		instance void set_Item (
			int32 indeks,
			string 'value'
		) cil managed 
	{
		// Method begins at RVA 0x21c6
		// Code size 16 (0x10)
		.maxstack 8

		IL_0000: nop
		IL_0001: ldarg.0
		IL_0002: ldfld class [mscorlib]System.Collections.Generic.List`1<string> zadanie.ListaKolorow::list
		IL_0007: ldarg.1
		IL_0008: ldarg.2
		IL_0009: callvirt instance void class [mscorlib]System.Collections.Generic.List`1<string>::set_Item(int32, !0)
		IL_000e: nop
		IL_000f: ret
	} // end of method ListaKolorow::set_Item

	.method public hidebysig specialname rtspecialname 
		instance void .ctor (
			string name
		) cil managed 
	{
		// Method begins at RVA 0x21d7
		// Code size 28 (0x1c)
		.maxstack 8

		IL_0000: ldarg.0
		IL_0001: call instance void [mscorlib]System.Object::.ctor()
		IL_0006: nop
		IL_0007: nop
		IL_0008: ldarg.0
		IL_0009: ldarg.1
		IL_000a: stfld string zadanie.ListaKolorow::nazwaListy
		IL_000f: ldarg.0
		IL_0010: newobj instance void class [mscorlib]System.Collections.Generic.List`1<string>::.ctor()
		IL_0015: stfld class [mscorlib]System.Collections.Generic.List`1<string> zadanie.ListaKolorow::list
		IL_001a: nop
		IL_001b: ret
	} // end of method ListaKolorow::.ctor

	.method public hidebysig 
		instance void dodajKolor (
			string kolor
		) cil managed 
	{
		// Method begins at RVA 0x21f4
		// Code size 15 (0xf)
		.maxstack 8

		IL_0000: nop
		IL_0001: ldarg.0
		IL_0002: ldfld class [mscorlib]System.Collections.Generic.List`1<string> zadanie.ListaKolorow::list
		IL_0007: ldarg.1
		IL_0008: callvirt instance void class [mscorlib]System.Collections.Generic.List`1<string>::Add(!0)
		IL_000d: nop
		IL_000e: ret
	} // end of method ListaKolorow::dodajKolor

	// Properties
	.property instance string name()
	{
		.get instance string zadanie.ListaKolorow::get_name()
		.set instance void zadanie.ListaKolorow::set_name(string)
	}
	.property instance string Item(
		int32 indeks
	)
	{
		.get instance string zadanie.ListaKolorow::get_Item(int32)
		.set instance void zadanie.ListaKolorow::set_Item(int32, string)
	}

} // end of class zadanie.ListaKolorow

