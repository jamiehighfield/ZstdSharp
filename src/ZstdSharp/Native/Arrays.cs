using System;
using static ZstdSharp.UnsafeHelper;

namespace ZstdSharp
{
    public static unsafe partial class Methods
    {
        static uint* rtbTable = GetArrayPointer(new uint[8] {
            0,
            473195,
            504333,
            520860,
            550000,
            700000,
            750000,
            830000,
        });
        static byte* LL_Code = GetArrayPointer(new byte[64] 
        {
            0,
            1,
            2,
            3,
            4,
            5,
            6,
            7,
            8,
            9,
            10,
            11,
            12,
            13,
            14,
            15,
            16,
            16,
            17,
            17,
            18,
            18,
            19,
            19,
            20,
            20,
            20,
            20,
            21,
            21,
            21,
            21,
            22,
            22,
            22,
            22,
            22,
            22,
            22,
            22,
            23,
            23,
            23,
            23,
            23,
            23,
            23,
            23,
            24,
            24,
            24,
            24,
            24,
            24,
            24,
            24,
            24,
            24,
            24,
            24,
            24,
            24,
            24,
            24,
        });
        static byte* ML_Code = GetArrayPointer(new byte[128] 
        {
            0,
            1,
            2,
            3,
            4,
            5,
            6,
            7,
            8,
            9,
            10,
            11,
            12,
            13,
            14,
            15,
            16,
            17,
            18,
            19,
            20,
            21,
            22,
            23,
            24,
            25,
            26,
            27,
            28,
            29,
            30,
            31,
            32,
            32,
            33,
            33,
            34,
            34,
            35,
            35,
            36,
            36,
            36,
            36,
            37,
            37,
            37,
            37,
            38,
            38,
            38,
            38,
            38,
            38,
            38,
            38,
            39,
            39,
            39,
            39,
            39,
            39,
            39,
            39,
            40,
            40,
            40,
            40,
            40,
            40,
            40,
            40,
            40,
            40,
            40,
            40,
            40,
            40,
            40,
            40,
            41,
            41,
            41,
            41,
            41,
            41,
            41,
            41,
            41,
            41,
            41,
            41,
            41,
            41,
            41,
            41,
            42,
            42,
            42,
            42,
            42,
            42,
            42,
            42,
            42,
            42,
            42,
            42,
            42,
            42,
            42,
            42,
            42,
            42,
            42,
            42,
            42,
            42,
            42,
            42,
            42,
            42,
            42,
            42,
            42,
            42,
            42,
            42,
        });
        static ZSTD_blockCompressor[][] blockCompressor = new ZSTD_blockCompressor[4][] 
        {
            new ZSTD_blockCompressor[10]
            {
                ZSTD_compressBlock_fast,
                ZSTD_compressBlock_fast,
                ZSTD_compressBlock_doubleFast,
                ZSTD_compressBlock_greedy,
                ZSTD_compressBlock_lazy,
                ZSTD_compressBlock_lazy2,
                ZSTD_compressBlock_btlazy2,
                ZSTD_compressBlock_btopt,
                ZSTD_compressBlock_btultra,
                ZSTD_compressBlock_btultra2,
            },
            new ZSTD_blockCompressor[10]
            {
                ZSTD_compressBlock_fast_extDict,
                ZSTD_compressBlock_fast_extDict,
                ZSTD_compressBlock_doubleFast_extDict,
                ZSTD_compressBlock_greedy_extDict,
                ZSTD_compressBlock_lazy_extDict,
                ZSTD_compressBlock_lazy2_extDict,
                ZSTD_compressBlock_btlazy2_extDict,
                ZSTD_compressBlock_btopt_extDict,
                ZSTD_compressBlock_btultra_extDict,
                ZSTD_compressBlock_btultra_extDict,
            },
            new ZSTD_blockCompressor[10]
            {
                ZSTD_compressBlock_fast_dictMatchState,
                ZSTD_compressBlock_fast_dictMatchState,
                ZSTD_compressBlock_doubleFast_dictMatchState,
                ZSTD_compressBlock_greedy_dictMatchState,
                ZSTD_compressBlock_lazy_dictMatchState,
                ZSTD_compressBlock_lazy2_dictMatchState,
                ZSTD_compressBlock_btlazy2_dictMatchState,
                ZSTD_compressBlock_btopt_dictMatchState,
                ZSTD_compressBlock_btultra_dictMatchState,
                ZSTD_compressBlock_btultra_dictMatchState,
            },
            new ZSTD_blockCompressor[10]
            {
                null,
                null,
                null,
                ZSTD_compressBlock_greedy_dedicatedDictSearch,
                ZSTD_compressBlock_lazy_dedicatedDictSearch,
                ZSTD_compressBlock_lazy2_dedicatedDictSearch,
                null,
                null,
                null,
                null,
            },
        };
        static searchMax_f[][] searchFuncs = new searchMax_f[4][] 
        {
            new searchMax_f[2]
            {
                ZSTD_HcFindBestMatch_selectMLS,
                ZSTD_BtFindBestMatch_selectMLS,
            },
            new searchMax_f[2]
            {
                null,
                null,
            },
            new searchMax_f[2]
            {
                ZSTD_HcFindBestMatch_dictMatchState_selectMLS,
                ZSTD_BtFindBestMatch_dictMatchState_selectMLS,
            },
            new searchMax_f[2]
            {
                ZSTD_HcFindBestMatch_dedicatedDictSearch_selectMLS,
                null,
            },
        };
        static decompressionAlgo[] decompress = new decompressionAlgo[2] 
        {
            HUF_decompress4X1,
            HUF_decompress4X2,
        };
        static uint* dec32table = GetArrayPointer(new uint[8] 
        {
            0,
            1,
            2,
            1,
            4,
            4,
            4,
            4,
        });
        static int* dec64table = GetArrayPointer(new int[8] 
        {
            8,
            8,
            8,
            7,
            8,
            9,
            10,
            11,
        });
    }
}