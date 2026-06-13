 #include <string>

class BlueprintTracker
{
public:
    int GetCompletionRate(int discovered, int total)
    {
        if (total == 0)
            return 0;

        return (discovered * 100) / total;
    }
};
