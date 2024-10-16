using UnityEngine;
using UnityEngine.EventSystems;

public class TowerManager : Loader<TowerManager>
{
    TowerBtn towerBtnPressed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit hit = new RaycastHit();
            if(Physics.Raycast(mousePoint, Camera.main.transform.forward, out hit, Mathf.Infinity))
            {
                PlaceTower(hit);
            }
        }
    }

    public void PlaceTower(RaycastHit hit)
    {
        if (!EventSystem.current.IsPointerOverGameObject() && towerBtnPressed != null)
        {
            GameObject newTower = Instantiate(towerBtnPressed.TowerObject);
            newTower.transform.position = hit.transform.position;
        }
       
    }

    public void SelectedTower(TowerBtn towerSelected)
    {
        towerBtnPressed = towerSelected;
    }
}
