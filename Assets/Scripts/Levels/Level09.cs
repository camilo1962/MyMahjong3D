public class Level09 : GameLevel
{
    private readonly int[,,] level = new int[5, 5, 5] //Total 108 cubos
    {
        {                                                                            //esta columna es el nivel superior
            { 1, 1, 1, 1, 1 },{ 1, 1, 1, 1, 1 },{ 1, 1, 1, 1, 1 },{ 1, 1, 1, 1, 1 }, { 1, 0, 1, 0, 1 }
        },
        {
            { 1, 1, 1, 1, 1 },{ 1, 1, 1, 1, 1 },{ 1, 1, 1, 1, 1 },{ 1, 1, 1, 1, 1 }, { 0, 1, 1, 1, 0 }
        },
        {
            { 1, 1, 1, 1, 1 },{ 1, 1, 1, 1, 1 },{ 1, 1, 1, 1, 1 },{ 1, 1, 1, 1, 1 }, { 1, 1, 0, 1, 1 }
        },
        {
            { 1, 1, 1, 1, 1 },{ 1, 1, 1, 1, 1 },{ 1, 1, 1, 1, 1 },{ 1, 1, 1, 1, 1 }, { 0, 1, 1, 1, 0 }
        },
        {
            { 1, 1, 1, 1, 1 },{ 1, 1, 1, 1, 1 },{ 1, 1, 1, 1, 1 },{ 1, 1, 1, 1, 1 }, { 1, 0, 1, 0, 1 }
        },
    };

    private readonly TileType[] typesInLevel = new TileType[] //Tiene que tener 8 tipos, por lo que (108 % 8) % 2 = 0
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