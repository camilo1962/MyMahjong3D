public class Level13: GameLevel
{
    private readonly int[,,] level = new int[7, 7, 7] //92 cubes
    {
        {
            {1,0,1,0,0,1,1}, { 0, 1, 1, 1, 0,1,1}, { 1, 1, 1, 1, 1, 1,1 }, { 0, 1, 1, 1, 0, 1 ,1}, { 0, 0, 1, 0, 0, 1,1 } ,{ 0, 0, 1, 0, 0, 1,1 },{ 0, 0, 1, 0, 0, 1,1 }//21
        },
        {
            { 0,1,1,1,0,1,1}, { 1, 1, 1, 1, 1, 1,1 }, { 1, 1, 1, 1, 1, 1,1 }, { 1, 1, 1, 1, 1, 1 ,1}, { 0, 1, 1, 1, 0, 1,1 }, { 0, 0, 1, 0, 0, 1 ,1} , {1, 0, 0, 1, 0, 0, 1 }//28
        },
        {
            {1, 1,1,1,1,1,1 }, { 1,1,1,1,1,1,1 }, {1, 1, 1, 1, 1, 1, 1 }, {1, 1,1,1,1,1, 1 }, { 1,1,1,1,1,1, 1 } ,{ 1,0, 0, 1, 0, 0, 1 }, { 1,0, 0, 1, 0, 0, 1 }//32
        },
        {
            { 1,0,1,1,1,0,1 }, { 1,1, 1, 1, 1, 1,1 }, {1, 1, 1, 1, 1, 1 ,1}, { 1,1, 1, 1, 1, 1,1 }, {1, 0, 1, 1, 1, 0,1 }, {1, 0, 0, 1, 0, 0,1 } , { 1,0, 0, 1, 0, 0, 1 }//28
        },
        {
            {1, 0,0,1,0,0,1 }, {1, 0, 1, 1, 1, 0,1 }, {1, 1, 1, 1, 1, 1,1 }, { 1,0, 1, 1, 1, 0,1 }, { 1,0, 0, 1, 0, 0,1 }, {1, 0, 0, 1, 0, 0,1 } , { 1,0, 0, 1, 0, 0, 1 }//20
        },
        {
            {1,1,1,1,1,1,1}, { 1,1, 1, 1, 1, 1,1}, { 1,1, 1, 1, 1, 1, 1 }, { 1,1, 1, 1, 1, 1, 1 }, { 1,1, 1, 1, 1, 1, 1 } ,{ 1,1, 1, 1, 1, 1, 1 } , { 1,0, 0, 1, 0, 0, 1 }//21
        },
         {
            { 1,1,1,1,1,1,1}, { 1, 1, 1, 1, 1, 1,1 }, { 1,1, 1, 1, 1, 1, 1 }, {1, 1, 1, 1, 1, 1, 1 }, { 1,0, 1, 1, 1, 0, 1 }, {1, 0, 0, 1, 0, 0, 1 } , {1, 0, 0, 1, 0, 0, 1 }//28
        },
    };


    private readonly TileType[] typesInLevel = new TileType[]
     {
        TileType.a,
        TileType.b,
        TileType.c,
        TileType.d,
        TileType.e,
        TileType.f,
        TileType.g,
        TileType.h,
        TileType.i,
        TileType.j,
        TileType.k,
        TileType.l,
        TileType.m,
        TileType.n,
        TileType.ñ,
        TileType.o,
        TileType.p,
        TileType.q,
        TileType.r,
        TileType.s,
        TileType.t,
        TileType.u,
        TileType.v,
        TileType.w,
        TileType.x,
        TileType.y,
        TileType.z,
        TileType.aa,
        TileType.bb,
        TileType.cc,
        TileType.dd,
        TileType.ff,
        TileType.gg,
        TileType.hh,
        TileType.ii
    };

    public override int[,,] GetLevel() => level;
    public override TileType[] GetTileTypesInLevel() => typesInLevel;
}