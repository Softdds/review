namespace DDS.FireblocksApi.Models.Callbacks
{
    public sealed class SignedMessage
    {
        /// <summary>
        /// The message for signing (hex-formatted)
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// The algorithm that was used for signing, one of the SigningAlgorithms
        /// </summary>
        public string Algorithm { get; set; }

        /// <summary>
        /// BIP32 derivation path of the signing key. E.g. [44,0,46,0,0]
        /// </summary>
        public int[] DerivationPath { get; set; }

        /// <summary>
        /// The message signature
        /// </summary>
        public Dictionary<string, string> Signature { get; set; }

        /// <summary>
        /// The signature's public key is used for verification.
        /// </summary>
        public string PublicKey { get; set; }
    }
}
