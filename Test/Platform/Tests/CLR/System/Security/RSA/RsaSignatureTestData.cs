using System.Security.Cryptography;
public class RsaSignatureTestData {
    
    public static byte[] GetHashValue() {
        return new byte[] {
                19,
                100,
                186,
                152,
                71,
                214,
                65,
                153,
                122,
                243,
                136,
                11,
                83,
                100,
                26,
                246,
                110,
                246,
                231,
                132};
    }
    
    public static byte[] GetSignatureValue() {
        return new byte[] {
                65,
                5,
                221,
                103,
                173,
                110,
                37,
                250,
                125,
                93,
                222,
                168,
                126,
                200,
                241,
                38,
                148,
                210,
                111,
                117,
                5,
                236,
                25,
                225,
                155,
                36,
                75,
                229,
                13,
                68,
                175,
                52,
                227,
                21,
                199,
                84,
                4,
                76,
                10,
                143,
                203,
                170,
                130,
                67,
                219,
                39,
                234,
                76,
                202,
                226,
                134,
                86,
                142,
                242,
                49,
                221,
                100,
                222,
                106,
                63,
                45,
                6,
                211,
                53,
                249,
                217,
                177,
                254,
                242,
                186,
                189,
                2,
                21,
                246,
                179,
                241,
                68,
                116,
                184,
                217,
                183,
                71,
                24,
                171,
                151,
                1,
                100,
                98,
                109,
                173,
                95,
                254,
                8,
                211,
                190,
                86,
                53,
                44,
                241,
                56,
                158,
                231,
                170,
                225,
                214,
                87,
                227,
                196,
                20,
                134,
                19,
                32,
                253,
                98,
                98,
                6,
                2,
                172,
                119,
                189,
                190,
                8,
                150,
                230,
                245,
                210,
                124,
                243};
    }
    
    public static System.Security.Cryptography.RSAParameters GetKeyParameters() {
        System.Security.Cryptography.RSAParameters parameters = new System.Security.Cryptography.RSAParameters();
        parameters.Exponent = new byte[] {
                1,
                0,
                1};
        parameters.Modulus = new byte[] {
                152,
                73,
                25,
                255,
                9,
                70,
                249,
                241,
                244,
                127,
                119,
                34,
                54,
                234,
                101,
                233,
                252,
                169,
                77,
                100,
                61,
                110,
                250,
                247,
                210,
                99,
                163,
                234,
                250,
                67,
                86,
                247,
                197,
                39,
                54,
                70,
                252,
                144,
                193,
                251,
                73,
                55,
                210,
                4,
                43,
                97,
                32,
                203,
                98,
                175,
                189,
                81,
                40,
                108,
                132,
                59,
                128,
                112,
                37,
                143,
                140,
                163,
                64,
                174,
                34,
                106,
                206,
                198,
                14,
                138,
                0,
                23,
                167,
                254,
                32,
                134,
                26,
                202,
                46,
                39,
                193,
                16,
                93,
                74,
                21,
                239,
                86,
                225,
                234,
                215,
                48,
                135,
                71,
                45,
                95,
                237,
                126,
                217,
                42,
                39,
                250,
                213,
                142,
                121,
                112,
                103,
                24,
                183,
                211,
                178,
                149,
                233,
                60,
                192,
                226,
                45,
                58,
                201,
                20,
                165,
                32,
                216,
                60,
                224,
                138,
                13,
                150,
                101};
        return parameters;
    }
}
