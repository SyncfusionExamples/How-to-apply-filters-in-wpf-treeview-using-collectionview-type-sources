using Microsoft.Xaml.Behaviors;
using Syncfusion.UI.Xaml.TreeView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SfTreeViewDemo
{
    /// <summary>
    /// Represents a class that used to trigger filter action for SfTeeView.
    /// </summary>
    public class TreeViewFilterTrigger : TargetedTriggerAction<SfTreeView>
    {
        /// <summary>
        /// Method used to hook the filter method when the SfTreeView is Loaded.
        /// </summary>
        /// <param name="parameter"></param>
        protected override void Invoke(object parameter)
        {
            var viewModel = this.Target.DataContext as FileManagerViewModel;
            viewModel.filterChanged += OnFilterChanged;
        }

        /// <summary>
        /// Method to filter the data.
        /// </summary>
        private void OnFilterChanged()
        {
            var viewModel = this.Target.DataContext as FileManagerViewModel;
            viewModel.CollectionView.Filter = (e) =>
            {
                FileManager file = e as FileManager;
                if ((file.FileName.ToLower()).Contains(viewModel.FilterText.ToLower()))
                    return true;
                if (file.SubFiles != null)
                {
                    foreach (var subFile in file.SubFiles)
                        if (subFile.FileName.ToLower().Contains(viewModel.FilterText.ToLower()))
                            return true;
                }
                return false;
            };
            this.Target.ExpandAll();

        }
    }
}
