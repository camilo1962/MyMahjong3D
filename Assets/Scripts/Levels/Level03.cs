public class Level03 : GameLevel
{
    private readonly int[,,] level = new int[3, 3, 3] //3*3*3 = 27, entonces 0 en el centro para que sea 26
    {
        {
            { 1, 1, 1},{ 1, 1, 1 },{ 1, 1, 1}
        },
        {
            { 1, 1, 1},{ 1, 0, 1 },{ 1, 1, 1}
        },
        {
            { 1, 1, 1},{ 1, 1, 1 },{ 1, 1, 1}
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