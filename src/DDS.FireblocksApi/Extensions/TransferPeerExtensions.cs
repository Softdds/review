using DDS.FireblocksApi.Constants;
using DDS.FireblocksApi.Models.Callbacks;

namespace DDS.FireblocksApi.Extensions
{
    public static class TransferPeerExtensions
    {
        public static bool IsVaultAccount(this TransferPeer peer)
        {
            return string.Equals(peer.Type, TransactionConstants.Peers.VaultAccount, StringComparison.InvariantCultureIgnoreCase);
        }

        public static bool IsExchangeAccount(this TransferPeer peer)
        {
            return string.Equals(peer.Type, TransactionConstants.Peers.ExchangeAccount, StringComparison.InvariantCultureIgnoreCase);
        }

        public static bool IsSystemVaultAccount(this TransferPeer peer)
        {
            return string.Equals(peer.Name, TransactionConstants.SystemVaultAccount, StringComparison.InvariantCultureIgnoreCase);
        }
    }
}
