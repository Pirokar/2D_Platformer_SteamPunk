var cube : Transform;
function Start () {
    for (var y = 0; y < 5; y++) {
        for (var x = 0; x < 5; x++) {
            var cube = Instantiate(cube, Vector3 (x, y, 21), Quaternion.identity);
        }
    }
} 