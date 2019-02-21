import qualified Data.Text as T
import Control.Monad

awesome = ["Papuchon","curry", ":)"]
also = ["Quake", "The Simons"]
allAwesome = [awesome, also]

-- isPalindrome :: (Eq a) => [a] -> Bool
-- isPalindrome x = x == reverse x
isPalindrome = join (==) . T.reverse . T.pack

absoluteVal :: Int -> Int
absoluteVal x = if x >= 0 then x else (negate x)


f :: (a,b) -> (c,d) -> ((b,d), (a,c))
f x y= ((snd x, snd y), (fst x, fst y))