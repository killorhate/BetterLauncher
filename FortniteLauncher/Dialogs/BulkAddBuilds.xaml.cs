using FortniteLauncher.Helpers;
using FortniteLauncher.Managers;
using FortniteLauncher.Pages;
using FortniteLauncher.Services;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace FortniteLauncher.Dialogs
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class BulkAddBuilds : Page
    {
        public BulkAddBuilds(ContentDialog SenderDialog)
        {
            this.InitializeComponent();

            SenderDialog.PrimaryButtonClick += SenderDialog_PrimaryButtonClick;
        }

        private async void SenderDialog_PrimaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
            // i will need to improve this its bad
            int Count = 0;
            foreach (var directories in Directory.GetDirectories(FolderBox.Text))
            {
                if (BuildsHelper.IsPathValid(directories))
                {
                    BuildsManager manager= new BuildsManager();
                    await manager.CreateBuild(Count.ToString(), directories, Enums.FortniteSeasons.Unknown);
                    Count++
                        ;
                }
                else
                {
                    if (BuildsHelper.IsPathValid(directories))
                    {
                        BuildsManager manager = new BuildsManager();
                        await manager.CreateBuild(Count.ToString(), directories, Enums.FortniteSeasons.Unknown);
                        Count++
                            ;
                    }
                    else
                    {
                        if (BuildsHelper.IsPathValid(directories))
                        {
                            BuildsManager manager = new BuildsManager();
                            await manager.CreateBuild(Count.ToString(), directories, Enums.FortniteSeasons.Unknown);
                            Count++
                                ;
                        }
                        else
                        {
                            if (BuildsHelper.IsPathValid(directories))
                            {
                                BuildsManager manager = new BuildsManager();
                                await manager.CreateBuild(Count.ToString(), directories, Enums.FortniteSeasons.Unknown);
                                Count++
                                    ;
                            }
                            else
                            {
                                if (BuildsHelper.IsPathValid(directories))
                                {
                                    BuildsManager manager = new BuildsManager();
                                    await manager.CreateBuild(Count.ToString(), directories, Enums.FortniteSeasons.Unknown);
                                    Count++
                                        ;
                                }
                                else
                                {
                                    foreach (var item in Directory.GetDirectories(directories))
                                    {
                                        BuildsManager manager = new BuildsManager();
                                        await manager.CreateBuild(Count.ToString(), directories, Enums.FortniteSeasons.Unknown);
                                        Count++;
                                    }
                                }
                            }
                        }
                    }
                }
            }

            sender.Hide();

            //refresh the page
            NavigationService.UpdateBreadcrumb("Select a build", true);
            NavigationService.ShowBreadcrumb();
            Globals.Objects.MainFrame.Navigate(typeof(PlayPage));
        }
    }
}
