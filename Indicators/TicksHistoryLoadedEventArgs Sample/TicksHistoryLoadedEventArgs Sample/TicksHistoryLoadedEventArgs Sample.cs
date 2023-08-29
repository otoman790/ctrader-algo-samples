// -------------------------------------------------------------------------------------------------
//
//    This code is a cTrader Automate API example.
//
//    This Indicator is intended to be used as a sample and does not guarantee any particular outcome or
//    profit of any kind. Use it at your own risk.
//
// -------------------------------------------------------------------------------------------------

using cAlgo.API;
using cAlgo.API.Internals;

namespace cAlgo
{
    [Indicator(IsOverlay = true, TimeZone = TimeZones.UTC, AccessRights = AccessRights.None)]
    public class TicksHistoryLoadedEventArgsSample : Indicator
    {
        private Ticks _ticks;

        [Parameter("Symbol Name", DefaultValue = "EURUSD")]
        public string InputSymbolName { get; set; }

        protected override void Initialize()
        {
            // Getting a symbol ticks data
            _ticks = MarketData.GetTicks(InputSymbolName);

            _ticks.HistoryLoaded += Ticks_HistoryLoaded;
            // You can also pass a callback method instead of subscribing to HistoryLoaded event
            //_ticks.LoadMoreHistoryAsync(Ticks_HistoryLoaded);
            _ticks.LoadMoreHistoryAsync();

            _ticks.Reloaded += Ticks_Reloaded;
        }

        private void Ticks_Reloaded(TicksHistoryLoadedEventArgs obj)
        {
            Print("Ticks got reloaded");
        }

        private void Ticks_HistoryLoaded(TicksHistoryLoadedEventArgs obj)
        {
            Print("New ticks loaded: #", obj.Count);
        }

        public override void Calculate(int index)
        {
        }
    }
}
