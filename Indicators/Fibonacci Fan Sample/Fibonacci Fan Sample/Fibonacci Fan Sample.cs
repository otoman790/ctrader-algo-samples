// -------------------------------------------------------------------------------------------------
//
//    This code is a cTrader Automate API example.
//
//    This Indicator is intended to be used as a sample and does not guarantee any particular outcome or
//    profit of any kind. Use it at your own risk.
//
// -------------------------------------------------------------------------------------------------

using cAlgo.API;

namespace cAlgo
{
    [Indicator(IsOverlay = true, TimeZone = TimeZones.UTC, AccessRights = AccessRights.None)]
    public class FibonacciFanSample : Indicator
    {
        protected override void Initialize()
        {
            Chart.DrawFibonacciFan("Fan", Chart.FirstVisibleBarIndex, Bars.ClosePrices[Chart.FirstVisibleBarIndex], Chart.LastVisibleBarIndex, Bars.ClosePrices[Chart.LastVisibleBarIndex], Color.Red);
        }

        public override void Calculate(int index)
        {
        }
    }
}
