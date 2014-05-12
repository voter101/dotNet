/*
 *
 * Zegar
 *
 */
#include <windows.h>

#define ID_TIMER    1

int xSize, ySize;

/* Deklaracje wyprzedzaj�ce */
LRESULT CALLBACK WindowProcedure(HWND, UINT, WPARAM, LPARAM);
void PaintCurrentTime( HDC hdc );

/* Nazwa klasy okna */
char szClassName[] = "PRZYKLAD";

int WINAPI WinMain(HINSTANCE hThisInstance, HINSTANCE hPrevInstance, 
                   LPSTR lpszArgument, int nFunsterStil)
{
    HWND hwnd;               /* Uchwyt okna */
    MSG messages;            /* Komunikaty okna */
    WNDCLASSEX wincl;        /* Struktura klasy okna */

    /* Klasa okna */
    wincl.hInstance     = hThisInstance;
    wincl.lpszClassName = szClassName;
    wincl.lpfnWndProc   = WindowProcedure;    // wska�nik na funkcj� 
                                              // obs�ugi okna  
    wincl.style         = CS_DBLCLKS;                 
    wincl.cbSize        = sizeof(WNDCLASSEX);

    /* Domy�lna ikona i wska�nik myszy */
    wincl.hIcon   = LoadIcon(NULL, IDI_APPLICATION);
    wincl.hIconSm = LoadIcon(NULL, IDI_APPLICATION);
    wincl.hCursor = LoadCursor(NULL, IDC_ARROW);
    wincl.lpszMenuName = NULL; 
    wincl.cbClsExtra = 0;   
    wincl.cbWndExtra = 0;   
    /* Jasnoszare t�o */
    wincl.hbrBackground = (HBRUSH)GetStockObject(LTGRAY_BRUSH);

    /* Rejestruj klas� okna */
    if(!RegisterClassEx(&wincl)) return 0;

    /* Tw�rz okno */
    hwnd = CreateWindowEx(
           0,                   
           szClassName,         
           "Przyk�ad",       
           WS_OVERLAPPEDWINDOW, 
           CW_USEDEFAULT,       
           CW_USEDEFAULT,       
           512,                 
           256,                 
           HWND_DESKTOP,        
           NULL,                
           hThisInstance,       
           NULL                 
           );

    ShowWindow(hwnd, nFunsterStil);
    /* P�tla obs�ugi komunikat�w */
    while(GetMessage(&messages, NULL, 0, 0))
    {
           /* T�umacz kody rozszerzone */
           TranslateMessage(&messages);
           /* Obs�u� komunikat */
           DispatchMessage(&messages);
    }

    /* Zwr�� parametr podany w PostQuitMessage( ) */
    return messages.wParam;
}

/* T� funkcj� wo�a DispatchMessage( ) */
LRESULT CALLBACK WindowProcedure(HWND hwnd, UINT message, 
                                 WPARAM wParam, LPARAM lParam)
{
    PAINTSTRUCT ps; 
    RECT        r;
    HDC         hdc;

    switch (message)                  
    {
           case WM_CREATE:
               SetTimer(hwnd, ID_TIMER, 500, NULL);
               break;
           case WM_TIMER:
               GetClientRect( hwnd, &r );
               InvalidateRect( hwnd, &r, 1 );
               break; 
           case WM_PAINT:
               hdc = BeginPaint( hwnd, &ps );               
               PaintCurrentTime( hdc );	
               EndPaint( hwnd, &ps );              
               break;
           case WM_SIZE:
               xSize = LOWORD(lParam);
               ySize = HIWORD(lParam);
               break; 
           case WM_DESTROY:
               KillTimer(hwnd, ID_TIMER); 
               PostQuitMessage(0);        
               break;
           default:                   
               return DefWindowProc(hwnd, message, wParam, lParam);
    }
    return 0;
}

/* Maluj aktualny czas na ekranie */
void PaintCurrentTime( HDC hdc )
{
    char sTime[256];
    SYSTEMTIME time;
    HFONT      hFont;
    SIZE       size;
    
    // pobierz aktualny czas systemowy
    // i konwertuj go na zadany format
    GetSystemTime( &time );
    GetTimeFormat( LOCALE_SYSTEM_DEFAULT, 0, &time, 
                   "HH':'mm':'ss", sTime, 256 );

    // tw�rz font logiczny
    hFont = CreateFont( 112, 0, 0, 0, 
                        FW_NORMAL, 0, 0, 0, 
                        DEFAULT_CHARSET, OUT_DEFAULT_PRECIS,
                        CLIP_DEFAULT_PRECIS, DEFAULT_QUALITY,
                        DEFAULT_PITCH, "LED" );
    SelectObject( hdc, hFont );

    // licz rozmiar tekstu
    GetTextExtentPoint32 (hdc, sTime, lstrlen (sTime), &size) ;

    // rozpocznij �cie�k� graficzn�
    BeginPath (hdc) ;

    SetBkMode( hdc, TRANSPARENT );
    TextOut( hdc, (xSize-size.cx)/2, (ySize-size.cy)/2, 
             sTime, strlen( sTime ) );               

    // zako�cz �cie�k�
    EndPath (hdc) ;

    // rysuj �cie�k� odpowiednim p�dzlem
    SelectObject (hdc, CreateHatchBrush (HS_DIAGCROSS, RGB (0, 0, 255))) ;
    SetBkColor (hdc, RGB (255, 0, 0)) ;
    SetBkMode (hdc, OPAQUE) ;
    StrokeAndFillPath (hdc) ;

    DeleteObject (SelectObject (hdc, GetStockObject (WHITE_BRUSH)));
    SelectObject (hdc, GetStockObject (SYSTEM_FONT)) ;
    DeleteObject (hFont) ;
}
