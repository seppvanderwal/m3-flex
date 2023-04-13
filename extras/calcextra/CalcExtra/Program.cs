static void Main()
{
    float x1 = 50f;
    float y1 = 50f;
    float x2 = 60f;
    float y2 = 50f;
    float rad1 = 5f;
    float rad2 = 5f;
    float testLength = 15f;

    float dx = x2 - x1;
    float dy = y2 - y1;
    double length = Math.Sqrt((dx * dx) + (dy * dy));
    bool collide = length <= rad1 + rad2 + testLength;

    Console.WriteLine(collide);
}
Main();