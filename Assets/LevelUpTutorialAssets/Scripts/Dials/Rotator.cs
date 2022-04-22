using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

namespace LevelUP.Dial
{
    public class Rotator : MonoBehaviour
    {
        public enum Direction { North, East, South, West };

        [SerializeField] Transform linkedDial;
        [SerializeField] private int snapRotationAmount = 25;
        [SerializeField] private float angleTolerance;
        [SerializeField] private GameObject RighthandModel;
        [SerializeField] private GameObject LefthandModel;
        [SerializeField] bool shouldUseDummyHands;
        [SerializeField] private GameObject knob;
        [SerializeField] float maxAngle;
        [SerializeField] float minAngle;

        private XRBaseInteractor interactor;
        private float startAngle;
        private bool requiresStartAngle = true;
        private bool shouldGetHandRotation = false;
        private XRGrabInteractable grabInteractor => GetComponent<XRGrabInteractable>();

        //Mark Suter's adjustments
        public void ItRotatedActivated()
        {
            Debug.Log("It --Activate-- Rotated to a Z of " + knob.transform.eulerAngles.z);
        }

        public void ItRotatedSelEntered()
        {
            Debug.Log("It --SelectEntered-- Rotated to a Z of " + knob.transform.eulerAngles.z);
        }

        public void ItRotatedSelExit()
        {
            Debug.Log("It --SelectExit-- Rotated to a Z of " + knob.transform.eulerAngles.z);
        }

        public void ItRotatedDeactivated()
        {
            Debug.Log("It --Deactivated-- Rotated to a Z of " + knob.transform.eulerAngles.z);
        }


        // End Mark Suter adjustments


        private void OnEnable()
        {
            grabInteractor.selectEntered.AddListener(GrabbedBy);
            grabInteractor.selectExited.AddListener(GrabEnd);
        }
        private void OnDisable()
        {
            grabInteractor.selectEntered.RemoveListener(GrabbedBy);
            grabInteractor.selectExited.RemoveListener(GrabEnd);
        }

        private void GrabEnd(SelectExitEventArgs arg0)
        {
            shouldGetHandRotation = false;
            requiresStartAngle = true;
            HandModelVisibility(false);

            Debug.Log("Grab Ended?");
        }

        private void GrabbedBy(SelectEnterEventArgs arg0)
        {

            Debug.Log("GrabbedBy?");

            interactor = GetComponent<XRGrabInteractable>().selectingInteractor;
            interactor.GetComponent<XRDirectInteractor>().hideControllerOnSelect = true;

            shouldGetHandRotation = true;
            startAngle = 0f;

            HandModelVisibility(true);
        }

        private void HandModelVisibility(bool visibilityState)
        {
            if (!shouldUseDummyHands)
                return;

            if (interactor.CompareTag("RightHand"))
                RighthandModel.SetActive(visibilityState);
            else
                LefthandModel.SetActive(visibilityState);
        }

        void Update()
        {
            if (shouldGetHandRotation)
            {
                Debug.Log("shouldGetHandRotation in Update???");
                var rotationAngle = GetInteractorRotation(); //gets the current controller angle
                GetRotationDistance(rotationAngle);
            }
        }

        public float GetInteractorRotation() => interactor.GetComponent<Transform>().eulerAngles.z;

        #region TheMath!
        private void GetRotationDistance(float currentAngle)
        {
            if (!requiresStartAngle)
            {
                var angleDifference = Mathf.Abs(startAngle - currentAngle);

                if (angleDifference > angleTolerance)
                {
                    if (angleDifference > 270f) //checking to see if the user has gone from 0-360 - a very tiny movement but will trigger the angletolerance
                    {
                        float angleCheck;

                        if (startAngle < currentAngle) 
                        {
                            angleCheck = CheckAngle(currentAngle, startAngle);

                            if (angleCheck < angleTolerance)
                                return;
                            else
                            {
                                RotateDialClockwise();
                                startAngle = currentAngle;
                            }
                        }
                        else if (startAngle > currentAngle) 
                        {
                            angleCheck = CheckAngle(currentAngle, startAngle);

                            if (angleCheck < angleTolerance)
                                return;
                            else
                            {
                                RotateDialAntiClockwise();
                                startAngle = currentAngle;
                            }
                        }
                    }
                    else
                    {
                        if (startAngle < currentAngle)
                        {
                            RotateDialAntiClockwise();
                            startAngle = currentAngle;
                        }
                        else if (startAngle > currentAngle)
                        {
                            RotateDialClockwise();
                            startAngle = currentAngle;
                        }
                    }
                }
            }
            else
            {
                requiresStartAngle = false;
                startAngle = currentAngle;
            }
        }
        #endregion

        private float CheckAngle(float currentAngle, float startAngle) => (360f - currentAngle) + startAngle;

        private void RotateDialClockwise()
        {
            Debug.Log("Clockwise ATTEMPTED");

            if(knob.transform.eulerAngles.z <= maxAngle)
            {
                linkedDial.localEulerAngles = new Vector3(linkedDial.localEulerAngles.x, 
                                                          linkedDial.localEulerAngles.y, 
                                                          linkedDial.localEulerAngles.z + snapRotationAmount);
                Debug.Log("After CW, Z-rot = " + knob.transform.eulerAngles.z);
            }
            

            if (TryGetComponent<IDial>(out IDial dial))
                dial.DialChanged(linkedDial.localEulerAngles.z);
        }

        private void RotateDialAntiClockwise()
        {

            Debug.Log("ANTI Clockwise???");
            if (knob.transform.eulerAngles.z >= minAngle)
            {
                    linkedDial.localEulerAngles = new Vector3(linkedDial.localEulerAngles.x, 
                                                                          linkedDial.localEulerAngles.y, 
                                                                          linkedDial.localEulerAngles.z - snapRotationAmount);
                Debug.Log("After ANTI, Z-rot = " + knob.transform.eulerAngles.z);
            }
                

            if(TryGetComponent<IDial>(out IDial dial))
                dial.DialChanged(linkedDial.localEulerAngles.z);
        }
    }
}
