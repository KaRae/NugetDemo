nuget.exe pack MyLib.nuspec -OutputDirectory Packages
nuget.exe pack MyLib-pre.nuspec -Symbols -SymbolPackageFormat snupkg -OutputDirectory Packages