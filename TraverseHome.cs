using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TraverseHome : MonoBehaviour
{
    public Camera panoramicView;
    public Camera hobbyAreaView;
    public Camera kitchenView;
    public Camera bathtubView;
    public Camera masterBedroomView;
    public Camera mainHallView;
    public Camera guestRoomView;
    public Camera jakuziView;
    public Camera guestRoom2View;
    public Camera livingRoomView;
    public Camera couchView;


    public void switchCam(int x)
    {

        deactivateAllCameras();
        if (x == 1)
        {
            panoramicView.enabled = true;
        }
        if (x == 2)
        {
            hobbyAreaView.enabled = true;
        }
        if (x == 3)
        {
            kitchenView.enabled = true;
        }
        if (x == 4)
        {
            bathtubView.enabled = true;
        }
        if (x == 5)
        {
            masterBedroomView.enabled = true;
        }
        if (x == 6)
        {
            mainHallView.enabled = true;
        }
        if (x == 7)
        {
            guestRoomView.enabled = true;
        }
        if (x == 8)
        {
            jakuziView.enabled = true;
        }
        if (x == 9)
        {
            guestRoom2View.enabled = true;
        }
        if (x == 10)
        {
            livingRoomView.enabled = true;
        }
        if (x == 11)
        {
            couchView.enabled = true;
        }
    }

    public void deactivateAllCameras()
    {
        panoramicView.enabled = false;
        hobbyAreaView.enabled = false;
        kitchenView.enabled = false;
        bathtubView.enabled = false;
        masterBedroomView.enabled = false;
        mainHallView.enabled = false;
        guestRoomView.enabled = false;
        jakuziView.enabled = false;
        guestRoom2View.enabled = false;
        livingRoomView.enabled = false;
        couchView.enabled = false;
    }
}
