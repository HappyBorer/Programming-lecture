int speedFirstFriend = 2;
int speedSecondFriend = 3;
int speedDog = 6;
int counter = 0;
double distance = 3000;
int limitDistance = 50;
bool friends = true;
while(distance > limitDistance)
{
    double time = 0;
    if(friends == true)
    {
        time = distance / (speedSecondFriend + speedDog);
        distance = distance - time * (speedFirstFriend + speedSecondFriend);
        friends = false;
    }
    else
    {
        time = distance / (speedFirstFriend + speedDog);
        distance = distance - time * (speedFirstFriend + speedSecondFriend);
        friends = true;
    }
    counter++;
}
Console.WriteLine(counter);
