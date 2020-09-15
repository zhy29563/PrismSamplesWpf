namespace CustomRegions
{
   public class StackPanelRegionAdapter : Prism.Regions.RegionAdapterBase<System.Windows.Controls.StackPanel>
   {
      public StackPanelRegionAdapter(Prism.Regions.IRegionBehaviorFactory regionBehaviorFactory) : base(regionBehaviorFactory)
      {

      }

      protected override void Adapt(Prism.Regions.IRegion region, System.Windows.Controls.StackPanel regionTarget)
      {
         // 区域内视图集合发生变化时引发的事件
         region.Views.CollectionChanged += (s, e) =>
         {
            if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
            {
               foreach (System.Windows.FrameworkElement element in e.NewItems)
               {
                  regionTarget.Children.Add(element);
               }
            }
            else if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Remove)
            {
               foreach (System.Windows.FrameworkElement element in e.NewItems)
               {
                  if(regionTarget.Children.Contains(element))
                     regionTarget.Children.Remove(element);
               }
            }
         };
      }

      protected override Prism.Regions.IRegion CreateRegion()
      {
         return new Prism.Regions.AllActiveRegion();
      }
   }
}
