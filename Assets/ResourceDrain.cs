using UnityEngine;

public class ResourceDrain : MonoBehaviour
{
    private Resources m_Resource;
    public string m_ResourceName = "playerWater";
    public float m_DrainSpeed = 1;
    // Update is called once per frame
    private void Start()
    {
        m_Resource = Resources.Find(m_ResourceName);
    }
    void Update()
    {
        m_Resource.Change(-m_DrainSpeed * Time.deltaTime);
    }
}
