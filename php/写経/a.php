
<?php

return
'default' => env('BROADCAST_DRIVER','null')

'connections' => [

    'pusher' =>[
        'driver'=> 'pusher',
        'key' => env('PUSHER_APP_KEY'),
        'serect' =>env('PUSHER_APP_ID')
        'option' => [
            'cluster' => env('PUSHER_APP_CLUSTER'),
        ]
     ]
]