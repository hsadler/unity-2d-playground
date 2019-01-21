using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ExitGame() {
        Application.Quit();
    }

    public void GoToBoilingSquaresScene() {
        SceneManager.LoadScene("BoilingSquares");
    }

    public void GoToGreenGasScene() {
        SceneManager.LoadScene("GreenGas");
    }

    public void GoToTileFactoryScene() {
        SceneManager.LoadScene("TileFactory");
    }

    public void GoToBallShooterScene() {
        SceneManager.LoadScene("BallShooter");
    }

    public void GoToPumpBalloonScene() {
        SceneManager.LoadScene("PumpBalloon");
    }

    public void GoToLeverAndFulcrumScene() {
        SceneManager.LoadScene("LeverAndFulcrum");
    }
    
    public void GoToStickyCannonScene() {
        SceneManager.LoadScene("StickyCannon");
    }

    public void GoToPendulumsScene() {
        SceneManager.LoadScene("Pendulums");
    }

    public void GoToReleaseTriggerScene() {
        SceneManager.LoadScene("ReleaseTrigger");
    }

    public void GoToConveyorBeltScene() {
        SceneManager.LoadScene("ConveyorBelt");
    }

}
