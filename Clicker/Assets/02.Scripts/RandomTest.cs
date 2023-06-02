using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 public class RandomTest : MonoBehaviour
    {
        [Header("Ȯ�� ����")]
        public float[] pr;

        void Start()
        {
            float value = Choose(pr);
            print(value);
        }

        float Choose(float[] probs)
        {

            float total = 0;

            foreach (float elem in probs)
            {
                total += elem;
            }

            float randomPoint = Random.value * total;

            for (int i = 0; i < probs.Length; i++)
            {
                if (randomPoint < probs[i])
                {
                    return i;
                }
                else
                {
                    randomPoint -= probs[i];
                }
            }
            return probs.Length - 1;
        }
    }

