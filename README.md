# NugetDemo

This repository demonstrates how NuGet symbol packages can be created and consumed.  
See https://docs.microsoft.com/en-us/nuget/create-packages/symbol-packages-snupkg for more information.

## Get started

1. Clone this repo
2. Open *Framework/MyLib/MyLib.sln*
3. Build it in debug **AND** release configuration
4. Run *NugetDemoMaster/Nuget/BuildPackages.bat*
5. Verify that */Packages* contains three files (2x *.nupkg, 1x *.snupkg)
6. In VS go to ``Tools`` > ``NuGet Package Manager`` > ``Package Manager Settings``
7. Select the subnode "Package Sources"
8. Click the plus sign on the right and pick the folder with the three packages
   (Step 5)  
   (***Note:*** you may have to disable certain online sources e.g. DevExpress, as it will cause the package lookup to fail)
9. Open *Consumer/Consumer/Consumer.sln*
10. Manage Nuget Packages
11. Uninstall the currently "installed" package, install the available one from your
    custom source
12. Run the consumer => (you'll see an exception)
13. Manage Nuget Packages again, this time check ``Include prerelease``, select the version ending in ``-pre``
14. Run the consumer again => you'll have stepped inside the "Greeter" class, set breakpoints or use F10/F11 to move

## Cleanup
1. In VS, open package sources, remove your custom source
2. Enable all sources you might have to disable
3. Close VS and delete the NugetDemo-master directory
