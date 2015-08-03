using UnityEngine;
 
public class Game : MonoBehaviour
{

    // набранные очки
    public static int points;
 
    private string _pointsString;
    private int _lastPonts = -1;
 
    // генерируем уровень при загрузке сцены
    public void Awake()
    {
        // обнуляем очки
        points = 0;
    }
 
    public void Update()
    {
        // обновление отображаемого текста очков только при их изменении
        if (_lastPonts == points) return;
 
        _lastPonts = points;
        // форматируем очки в формате четырех цифр, начинающихся с нулей
        _pointsString = "Score: "+ points.ToString("0000");
    }
 
 
    // отрисовка набранных очков
    public void OnGUI()
    {
        GUI.color = Color.yellow;
        GUI.Label(new Rect(100, 0, 200, 20), _pointsString ?? "");
    }
}
