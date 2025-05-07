



int[] flowerbed = {1,0,0,0,1};
int n = 1;

int count = 0;

for (int i = 0; i < flowerbed.Length; i++)
{
    if (flowerbed[i] == 0)
    {
        bool zeroLeft = (i == 0 || flowerbed[i-1] == 0);
        bool zeroRight = (i == flowerbed.Length - 1 || flowerbed[i+1] ==0);

        if (zeroLeft && zeroRight)
        {
            flowerbed[i] = 1;
            count++;
        }
    }
}

Console.WriteLine(count >= n);



/*
 flowers can't be planted next to each other
0 is empty, 1 is planted

1,0,0,0,1 means i can place 1 in the center to follow rule

 
 if the current spot is 0 and the ones left and right of it are 0 or null,
then we can change the 0 to a 1
otherwise it's false
 
iterate through each spot
check if that spot is a 0. then 
 
 */