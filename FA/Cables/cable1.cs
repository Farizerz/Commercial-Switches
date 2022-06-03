using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cable1 : MonoBehaviour
{
    public bool _Cable_Static;
    public LineRenderer ln_;
    public float line_width;
    public float tingkat_renggang;
    float jarak, jarak_per_point;
    //public float  panjang_kabel,total_panjang;
    public Transform[] titik, titik_static;
    Vector3 pos_titik0, pos_titik9;


    // Start is called before the first frame update
    void Start()
    {
        make_line();
        ln_.startWidth = line_width;
    }

    // Update is called once per frame
    void Update()
    {
        if (_Cable_Static)
        {
            make_line_static();
        }
        else
        {
            make_line();
        }

        //if (total_panjang < panjang_kabel)
        //{
        //    float temp_ = panjang_kabel - total_panjang;
        //    if (temp_ > 1)
        //    {
        //        kelipatan += Time.deltaTime* (temp_*10);
        //    }
        //    else
        //    {
        //        kelipatan += Time.deltaTime;
        //    }
        //}

        //if (total_panjang > panjang_kabel)
        //{
        //    float temp_ = total_panjang - panjang_kabel;
        //    if (temp_ > 1)
        //    {
        //        kelipatan -= Time.deltaTime * (temp_ * 10);
        //    }
        //    else
        //    {
        //        kelipatan -= Time.deltaTime;
        //    }
        //}
    }

    public void make_line()
    {
        jarak = Vector3.Distance(titik[0].position, titik[titik.Length - 1].position);
        jarak_per_point = jarak / 90;

        for (int i = 0; i < titik.Length; i++)
        {
            titik[i].position = Vector3.MoveTowards(titik[0].position, titik[titik.Length - 1].position, jarak_per_point * (i * 10));
        }

        for (int i = 0; i < titik.Length; i++)
        {
            ln_.SetPosition(i, new Vector3(titik[i].position.x, titik[i].position.y - ((Mathf.Sin(((i * 20) * Mathf.PI) / 180)) * tingkat_renggang), titik[i].position.z));
        }

        pos_titik0 = titik[0].position;
        pos_titik9 = titik[9].position;

        for (int i = 0; i < titik_static.Length; i++)
        {
            titik_static[i].transform.position = ln_.GetPosition(i);
        }

        //total_panjang = (Vector3.Distance(ln_.GetPosition(0), ln_.GetPosition(1))) +
        //               (Vector3.Distance(ln_.GetPosition(1), ln_.GetPosition(2))) +
        //               (Vector3.Distance(ln_.GetPosition(2), ln_.GetPosition(3))) +
        //               (Vector3.Distance(ln_.GetPosition(3), ln_.GetPosition(4))) +
        //               (Vector3.Distance(ln_.GetPosition(4), ln_.GetPosition(5))) +
        //               (Vector3.Distance(ln_.GetPosition(5), ln_.GetPosition(6))) +
        //               (Vector3.Distance(ln_.GetPosition(6), ln_.GetPosition(7))) +
        //               (Vector3.Distance(ln_.GetPosition(7), ln_.GetPosition(8)));

    }

    public void make_line_static()
    {
        for (int i = 0; i < titik.Length; i++)
        {
            ln_.SetPosition(i, titik_static[i].position);
        }

    }
}
