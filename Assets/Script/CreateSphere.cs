using UnityEngine;

public class CreateSphere : MonoBehaviour
{
    void Start()
    {
        Vector3[] vc1 = new Vector3[36];
        Vector3[] vc2 = new Vector3[36 * 4];
        Vector3[] vc3 = new Vector3[36 * 4 * 4];
        Vector3[] vc4 = new Vector3[36 * 4 * 4 * 4];
        Vector3[] vc5 = new Vector3[36 * 4 * 4 * 4 * 4];
        int vc1l = 36;
        int vc2l = 36 * 4;
        int vc3l = 36 * 4 * 4;
        int vc4l = 36 * 4 * 4 * 4;
        int vc5l = 36 * 4 * 4 * 4 * 4;
        int[] tr1 = new int[36];
        int[] tr2 = new int[36 * 4];
        int[] tr3 = new int[36 * 4 * 4];
        int[] tr4 = new int[36 * 4 * 4 * 4];
        int[] tr5 = new int[36 * 4 * 4 * 4 * 4];
        int tr1l = 36;
        int tr2l = 36 * 4;
        int tr3l = 36 * 4 * 4;
        int tr4l = 36 * 4 * 4 * 4;
        int tr5l = 36 * 4 * 4 * 4 * 4;
        for (int i = 0; i < tr1l; i++)
        {
            tr1[i] = i;
        }
        Vector3 v1 = new Vector3(Mathf.Cos(Mathf.PI / 3.0f * 1.0f), Mathf.Sin(Mathf.PI / 3.0f * 1.0f), 0);
        Vector3 v2 = new Vector3(Mathf.Cos(Mathf.PI / 3.0f * 2.0f), Mathf.Sin(Mathf.PI / 3.0f * 2.0f), 0);
        Vector3 v3 = new Vector3(Mathf.Cos(Mathf.PI / 3.0f * 3.0f), Mathf.Sin(Mathf.PI / 3.0f * 3.0f), 0);
        Vector3 v4 = new Vector3(Mathf.Cos(Mathf.PI / 3.0f * 4.0f), Mathf.Sin(Mathf.PI / 3.0f * 4.0f), 0);
        Vector3 v5 = new Vector3(Mathf.Cos(Mathf.PI / 3.0f * 5.0f), Mathf.Sin(Mathf.PI / 3.0f * 5.0f), 0);
        Vector3 v6 = new Vector3(Mathf.Cos(Mathf.PI / 3.0f * 6.0f), Mathf.Sin(Mathf.PI / 3.0f * 6.0f), 0);
        Vector3 v7 = new Vector3(0, 0, 1);
        Vector3 v8 = new Vector3(0, 0, -1);
        vc1[ 0] = v1; vc1[ 1] = v7; vc1[ 2] = v2;
        vc1[ 3] = v2; vc1[ 4] = v7; vc1[ 5] = v3;
        vc1[ 6] = v3; vc1[ 7] = v7; vc1[ 8] = v4;
        vc1[ 9] = v4; vc1[10] = v7; vc1[11] = v5;
        vc1[12] = v5; vc1[13] = v7; vc1[14] = v6;
        vc1[15] = v6; vc1[16] = v7; vc1[17] = v1;
        vc1[18] = v2; vc1[19] = v8; vc1[20] = v1;
        vc1[21] = v3; vc1[22] = v8; vc1[23] = v2;
        vc1[24] = v4; vc1[25] = v8; vc1[26] = v3;
        vc1[27] = v5; vc1[28] = v8; vc1[29] = v4;
        vc1[30] = v6; vc1[31] = v8; vc1[32] = v5;
        vc1[33] = v1; vc1[34] = v8; vc1[35] = v6;
        for (int i = 0; i < vc1l; i += 3)
        {
            Vector3 t1 = vc1[i + 0];
            Vector3 t2 = vc1[i + 1];
            Vector3 t3 = vc1[i + 2];
            Vector3 t4 = ((t1 + t2) / 2.0f).normalized;
            Vector3 t5 = ((t2 + t3) / 2.0f).normalized;
            Vector3 t6 = ((t1 + t3) / 2.0f).normalized;
            vc2[i * 4 + 0] = t1;
            vc2[i * 4 + 1] = t4;
            vc2[i * 4 + 2] = t6;
            vc2[i * 4 + 3] = t4;
            vc2[i * 4 + 4] = t2;
            vc2[i * 4 + 5] = t5;
            vc2[i * 4 + 6] = t5;
            vc2[i * 4 + 7] = t3;
            vc2[i * 4 + 8] = t6;
            vc2[i * 4 + 9] = t4;
            vc2[i * 4 +10] = t5;
            vc2[i * 4 +11] = t6;
        }
        for (int i = 0; i < tr2l; i++)
        {
            tr2[i] = i;
        }
        for (int i = 0; i < vc2l; i += 3)
        {
            Vector3 t1 = vc2[i + 0];
            Vector3 t2 = vc2[i + 1];
            Vector3 t3 = vc2[i + 2];
            Vector3 t4 = ((t1 + t2) / 2.0f).normalized;
            Vector3 t5 = ((t2 + t3) / 2.0f).normalized;
            Vector3 t6 = ((t1 + t3) / 2.0f).normalized;
            vc3[i * 4 + 0] = t1;
            vc3[i * 4 + 1] = t4;
            vc3[i * 4 + 2] = t6;
            vc3[i * 4 + 3] = t4;
            vc3[i * 4 + 4] = t2;
            vc3[i * 4 + 5] = t5;
            vc3[i * 4 + 6] = t5;
            vc3[i * 4 + 7] = t3;
            vc3[i * 4 + 8] = t6;
            vc3[i * 4 + 9] = t4;
            vc3[i * 4 +10] = t5;
            vc3[i * 4 +11] = t6;
        }
        for (int i = 0; i < tr3l; i++)
        {
            tr3[i] = i;
        }
        for (int i = 0; i < vc3l; i += 3)
        {
            Vector3 t1 = vc3[i + 0];
            Vector3 t2 = vc3[i + 1];
            Vector3 t3 = vc3[i + 2];
            Vector3 t4 = ((t1 + t2) / 2.0f).normalized;
            Vector3 t5 = ((t2 + t3) / 2.0f).normalized;
            Vector3 t6 = ((t1 + t3) / 2.0f).normalized;
            vc4[i * 4 + 0] = t1;
            vc4[i * 4 + 1] = t4;
            vc4[i * 4 + 2] = t6;
            vc4[i * 4 + 3] = t4;
            vc4[i * 4 + 4] = t2;
            vc4[i * 4 + 5] = t5;
            vc4[i * 4 + 6] = t5;
            vc4[i * 4 + 7] = t3;
            vc4[i * 4 + 8] = t6;
            vc4[i * 4 + 9] = t4;
            vc4[i * 4 +10] = t5;
            vc4[i * 4 +11] = t6;
        }
        for (int i = 0; i < tr4l; i++)
        {
            tr4[i] = i;
        }

        for (int i = 0; i < vc4l; i += 3)
        {
            Vector3 t1 = vc4[i + 0];
            Vector3 t2 = vc4[i + 1];
            Vector3 t3 = vc4[i + 2];
            Vector3 t4 = ((t1 + t2) / 2.0f).normalized;
            Vector3 t5 = ((t2 + t3) / 2.0f).normalized;
            Vector3 t6 = ((t1 + t3) / 2.0f).normalized;
            vc5[i * 4 + 0] = t1;
            vc5[i * 4 + 1] = t4;
            vc5[i * 4 + 2] = t6;
            vc5[i * 4 + 3] = t4;
            vc5[i * 4 + 4] = t2;
            vc5[i * 4 + 5] = t5;
            vc5[i * 4 + 6] = t5;
            vc5[i * 4 + 7] = t3;
            vc5[i * 4 + 8] = t6;
            vc5[i * 4 + 9] = t4;
            vc5[i * 4 +10] = t5;
            vc5[i * 4 +11] = t6;
        }
        for (int i = 0; i < tr5l; i++)
        {
            tr5[i] = i;
        }

        Vector3[] vc = new Vector3[vc5l];
        int vcl = 0;
        for (int i = 0; i < vc5l; i++)
        {
            bool f = false;
            for (int j = 0; j < vcl; j++)
            {
                if (Vector3.Distance(vc5[i], vc[j]) < 0.001f)
                {
                    f = true;
                }
            }
            if (!f)
            {
                vc[vcl] = vc5[i];
                vcl++;
            }
        }
        int[] tr = new int[tr5l];
        int trl = 0;
        for (int i = 0; i < tr5l; i++)
        {
            int fc = 0;
            for (int j = 0; j < vcl; j++)
            {
                if (Vector3.Distance(vc5[tr5[i]], vc[j]) < 0.001f)
                {
                    fc++;
                    tr[trl] = j;
                    trl++;
                }
            }
        }

        int[] vt = new int[vcl];
        vt[0] = 1;
        vt[1] = 2;
        vt[2] = 3;
        bool r;
        do {
            r = false;
            for (int i = 0; i < trl; i += 3)
            {
                int t1 = vt[tr[i + 0]];
                int t2 = vt[tr[i + 1]];
                int t3 = vt[tr[i + 2]];
                if (t1 > 0 && t2 > 0 && t3 > 0)
                {
                    continue;
                }
                r = true;
                if (t1 == 0 && t2 == 0 || t1 == 0 && t3 == 0 || t2 == 0 && t3 == 0)
                {
                    continue;
                }
                if (t1 == 0)
                {
                    vt[tr[i + 0]] = FindNext(t2, t3);
                    //Debug.Log(t2+" "+t3+" "+vt[tr[i + 0]]);
                }
                if (t2 == 0)
                {
                    vt[tr[i + 1]] = FindNext(t1, t3);
                    //Debug.Log(t1+" "+t3+" "+vt[tr[i + 1]]);
                }
                if (t3 == 0)
                {
                    vt[tr[i + 2]] = FindNext(t1, t2);
                    //Debug.Log(t1+" "+t2+" "+vt[tr[i + 2]]);
                }
            }
        } while (r);
        
        Mesh m = new Mesh();
        int[] trf = new int[trl];
        Vector3[] vcf = new Vector3[vcl];
        Vector2[] uvf = new Vector2[vcl];
        for (int i = 0; i < trl; i++)
        {
            trf[i] = tr[i];
            if (vt[tr[i]] == 1)
            {
                uvf[tr[i]] = new Vector2(0, 0);
            }
            if (vt[tr[i]] == 2)
            {
                uvf[tr[i]] = new Vector2(0.5f, 0.8660254037844386f);
            }
            if (vt[tr[i]] == 3)
            {
                uvf[tr[i]] = new Vector2(1.0f, 0);
            }
        }
        for (int i = 0; i < vcl; i++)
        {
            vcf[i] = vc[i] * 0.5f;
        }
        m.vertices = vcf;
        m.triangles = trf;
        m.uv = uvf;
        GetComponent<MeshFilter>().mesh = m;
    }

    int FindNext(int a, int b)
    {
        if (a != 1 && b != 1)
        {
            return 1;
        }
        if (a != 2 && b != 2)
        {
            return 2;
        }
        if (a != 3 && b != 3)
        {
            return 3;
        }
        return 0;
    }
}
